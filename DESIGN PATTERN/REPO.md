### REPOSITORY PATTERN
What is the use case of repository design pattern?
The Repository Pattern is a design pattern that provides an abstraction layer between the data access layer and the rest of the application. It separates the logic that retrieves data from the data storage layer, providing a more modular approach to software development.

The repository pattern is a design pattern commonly used in software development to abstract the data access layer.

Abstracting the data access layer means creating a separation or interface between your application's business logic and the specific mechanisms used to retrieve and manipulate data from a data source, such as a database. This separation provides several benefits, including:
1. **Flexibility**: for Changing / Swapping Database
2. **Testability**: you can use Mocks
3. **Maintainability**: when change of code occur doesn't need to updated whole application
4. **Security**: can manage security at one place only


The Repository Pattern is a popular design pattern used to abstract data access logic from business logic in an application. Here's a basic example of how you can implement the Repository Pattern in a .NET Core application.

### Step 1: Create the Models

Let's assume we have a simple `Product` model:

```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
```

### Step 2: Create the DbContext

Set up the `AppDbContext` which inherits from `DbContext`:

```csharp
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
}
```

### Step 3: Create the Repository Interface

Define the repository interface for `Product`:

```csharp
public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product> GetByIdAsync(int id);
    Task AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(int id);
}
```

### Step 4: Implement the Repository

Create the implementation of the repository interface:

```csharp
public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task AddAsync(Product product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Product product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product != null)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}
```

### Step 5: Register Services in `Startup.cs`

Register the DbContext and Repository in the `Startup.cs`:

```csharp
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IProductRepository, ProductRepository>();

        // Other service registrations...
    }

    // Other methods...
}
```

### Step 6: Use the Repository in a Controller

Finally, inject the repository into a controller to use it:

```csharp
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductsController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _productRepository.GetAllAsync();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] Product product)
    {
        if (product == null)
        {
            return BadRequest();
        }

        await _productRepository.AddAsync(product);
        return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] Product product)
    {
        if (id != product.Id || product == null)
        {
            return BadRequest();
        }

        var existingProduct = await _productRepository.GetByIdAsync(id);
        if (existingProduct == null)
        {
            return NotFound();
        }

        await _productRepository.UpdateAsync(product);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        if (product == null)
        {
            return NotFound();
        }

        await _productRepository.DeleteAsync(id);
        return NoContent();
    }
}
```

This example shows how to implement the Repository Pattern in a .NET Core application, including setting up the model, DbContext, repository interface, repository implementation, and how to use it in a controller. This pattern helps in managing data access logic cleanly and makes the codebase more maintainable.