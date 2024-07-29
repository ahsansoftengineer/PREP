A self-join in a database occurs when a table is joined with itself. This can be useful in scenarios such as representing hierarchical data (e.g., an employee reporting structure). Below is an example of how to model and query such a structure using Entity Framework Core.

### Example Scenario: Employee Hierarchy

1. **Modeling the Employee Table**

First, create an `Employee` class that includes a self-referencing relationship to represent the hierarchy.

```csharp
public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public int? ManagerId { get; set; } // Nullable to allow top-level managers

    // Navigation property to represent the manager
    public Employee Manager { get; set; }
    // Navigation property to represent the subordinates
    public ICollection<Employee> Subordinates { get; set; }
}
```

2. **Configuring the Relationship in DbContext**

In your `DbContext` class, configure the self-referencing relationship.

```csharp
public class AppDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>()
            .HasOne(e => e.Manager)
            .WithMany(m => m.Subordinates)
            .HasForeignKey(e => e.ManagerId);
    }
}
```

3. **Example of Adding Data**

Here's how you might seed some data into the database to represent an employee hierarchy.

```csharp
public static void Seed(AppDbContext context)
{
    var manager = new Employee { Name = "Manager" };
    var employee1 = new Employee { Name = "Employee 1", Manager = manager };
    var employee2 = new Employee { Name = "Employee 2", Manager = manager };

    context.Employees.AddRange(manager, employee1, employee2);
    context.SaveChanges();
}
```

4. **Querying the Hierarchy**

To retrieve an employee and all their subordinates (direct and indirect), you can use a recursive method or LINQ query.

Here's an example of a method to retrieve an employee and all their subordinates using recursion:

```csharp
public List<Employee> GetEmployeeHierarchy(int employeeId, AppDbContext context)
{
    var employee = context.Employees
                          .Include(e => e.Subordinates)
                          .FirstOrDefault(e => e.EmployeeId == employeeId);

    if (employee == null) return new List<Employee>();

    var hierarchy = new List<Employee> { employee };
    AddSubordinates(employee, hierarchy);

    return hierarchy;
}

private void AddSubordinates(Employee manager, List<Employee> hierarchy)
{
    foreach (var subordinate in manager.Subordinates)
    {
        hierarchy.Add(subordinate);
        AddSubordinates(subordinate, hierarchy);
    }
}
```

This method first retrieves the specified employee along with their immediate subordinates. It then recursively adds all subordinates to the hierarchy list.

5. **Using the Method**

To use this method:

```csharp
using (var context = new AppDbContext())
{
    var hierarchy = GetEmployeeHierarchy(managerId, context);

    foreach (var employee in hierarchy)
    {
        Console.WriteLine(employee.Name);
    }
}
```

This setup and querying example should help you understand how to implement and use a self-join table to access all child records using Entity Framework Core.