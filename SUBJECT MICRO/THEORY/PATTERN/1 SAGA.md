The Saga pattern is a design pattern used to manage and coordinate transactions in a microservices architecture. It ensures data consistency and handles failures across multiple services by breaking a transaction into a series of smaller, atomic steps, with each step triggering the next. If a step fails, compensating actions are taken to undo the changes.

Here’s a simplified example of implementing the Saga pattern in .NET Core using a distributed transaction scenario for an e-commerce application. The example involves placing an order that spans multiple services: Order Service, Payment Service, and Inventory Service.

### Step-by-Step Implementation

#### 1. Define the Services

**Order Service**:
Handles creating and canceling orders.

**Payment Service**:
Handles processing and refunding payments.

**Inventory Service**:
Handles reserving and releasing inventory.

#### 2. Create Models and Interfaces

**Order Model**:
```csharp
public class Order
{
    public int Id { get; set; }
    public string Status { get; set; } // Created, Completed, Cancelled
}
```

**Payment Model**:
```csharp
public class Payment
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public string Status { get; set; } // Processed, Refunded
}
```

**Inventory Model**:
```csharp
public class Inventory
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public string Status { get; set; } // Reserved, Released
}
```

**Service Interfaces**:
```csharp
public interface IOrderService
{
    Order CreateOrder(Order order);
    void CancelOrder(int orderId);
}

public interface IPaymentService
{
    Payment ProcessPayment(int orderId);
    void RefundPayment(int orderId);
}

public interface IInventoryService
{
    Inventory ReserveInventory(int productId, int quantity);
    void ReleaseInventory(int productId, int quantity);
}
```

#### 3. Implement the Services

**OrderService**:
```csharp
public class OrderService : IOrderService
{
    private readonly List<Order> _orders = new List<Order>();

    public Order CreateOrder(Order order)
    {
        order.Id = _orders.Count + 1;
        order.Status = "Created";
        _orders.Add(order);
        return order;
    }

    public void CancelOrder(int orderId)
    {
        var order = _orders.FirstOrDefault(o => o.Id == orderId);
        if (order != null)
        {
            order.Status = "Cancelled";
        }
    }
}
```

**PaymentService**:
```csharp
public class PaymentService : IPaymentService
{
    private readonly List<Payment> _payments = new List<Payment>();

    public Payment ProcessPayment(int orderId)
    {
        var payment = new Payment { Id = _payments.Count + 1, OrderId = orderId, Status = "Processed" };
        _payments.Add(payment);
        return payment;
    }

    public void RefundPayment(int orderId)
    {
        var payment = _payments.FirstOrDefault(p => p.OrderId == orderId);
        if (payment != null)
        {
            payment.Status = "Refunded";
        }
    }
}
```

**InventoryService**:
```csharp
public class InventoryService : IInventoryService
{
    private readonly List<Inventory> _inventory = new List<Inventory>();

    public Inventory ReserveInventory(int productId, int quantity)
    {
        var inventory = new Inventory { Id = _inventory.Count + 1, ProductId = productId, Quantity = quantity, Status = "Reserved" };
        _inventory.Add(inventory);
        return inventory;
    }

    public void ReleaseInventory(int productId, int quantity)
    {
        var inventory = _inventory.FirstOrDefault(i => i.ProductId == productId && i.Quantity == quantity);
        if (inventory != null)
        {
            inventory.Status = "Released";
        }
    }
}
```

#### 4. Implement the Saga Coordinator

The Saga Coordinator orchestrates the transaction steps and handles compensations if any step fails.

```csharp
public class OrderSaga
{
    private readonly IOrderService _orderService;
    private readonly IPaymentService _paymentService;
    private readonly IInventoryService _inventoryService;

    public OrderSaga(IOrderService orderService, IPaymentService paymentService, IInventoryService inventoryService)
    {
        _orderService = orderService;
        _paymentService = paymentService;
        _inventoryService = inventoryService;
    }

    public void CreateOrderSaga(Order order, int productId, int quantity)
    {
        try
        {
            // Step 1: Create Order
            var createdOrder = _orderService.CreateOrder(order);

            // Step 2: Reserve Inventory
            var inventory = _inventoryService.ReserveInventory(productId, quantity);

            // Step 3: Process Payment
            var payment = _paymentService.ProcessPayment(createdOrder.Id);

            // If all steps succeed
            createdOrder.Status = "Completed";
        }
        catch (Exception ex)
        {
            // If any step fails, compensate

            // Cancel Order
            _orderService.CancelOrder(order.Id);

            // Release Inventory
            _inventoryService.ReleaseInventory(productId, quantity);

            // Refund Payment
            _paymentService.RefundPayment(order.Id);

            Console.WriteLine("Saga failed and compensation completed. Reason: " + ex.Message);
        }
    }
}
```

#### 5. Configure Dependency Injection and Run the Application

**Configure Services**:
```csharp
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IOrderService, OrderService>();
        services.AddSingleton<IPaymentService, PaymentService>();
        services.AddSingleton<IInventoryService, InventoryService>();
        services.AddSingleton<OrderSaga>();
    }
}
```

**Run the Saga**:
```csharp
public class Program
{
    public static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IOrderService, OrderService>()
            .AddSingleton<IPaymentService, PaymentService>()
            .AddSingleton<IInventoryService, InventoryService>()
            .AddSingleton<OrderSaga>()
            .BuildServiceProvider();

        var orderSaga = serviceProvider.GetService<OrderSaga>();

        var order = new Order();
        orderSaga.CreateOrderSaga(order, productId: 1, quantity: 10);
    }
}
```

This example demonstrates a simple implementation of the Saga pattern in .NET Core. The `OrderSaga` class coordinates the transaction across multiple services, handling compensations if any step fails, ensuring data consistency in a distributed system.