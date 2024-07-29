Here are some common .NET Core LINQ interview questions, along with examples to illustrate the concepts:

### Basic Questions

1. **What is LINQ?**
   - **Answer:** LINQ (Language Integrated Query) is a set of features in .NET that allows querying collections in a type-safe, readable, and concise manner. It provides a consistent syntax to query various data sources like in-memory collections, databases, XML, etc.

2. **What are the different types of LINQ?**
   - **Answer:**
     - LINQ to Objects
     - LINQ to SQL
     - LINQ to Entities (Entity Framework)
     - LINQ to XML
     - LINQ to DataSet

3. **What is the difference between `IEnumerable` and `IQueryable`?**
   - **Answer:**
     - `IEnumerable<T>` is used for in-memory collections and performs queries in memory.
     - `IQueryable<T>` is used for querying data from out-of-memory collections (like databases) and translates queries into the appropriate query language (e.g., SQL).

### Intermediate Questions

4. **How do you perform a basic LINQ query to filter data?**

   ```csharp
   var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
   var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

   foreach (var number in evenNumbers)
   {
       Console.WriteLine(number);
   }
   ```

5. **What is deferred execution in LINQ?**
   - **Answer:** Deferred execution means that the evaluation of a LINQ query is delayed until the query is actually iterated over (e.g., using `foreach` or `ToList`). This allows for query composition and optimization.

6. **How do you join two collections using LINQ?**

   ```csharp
   var employees = new List<Employee>
   {
       new Employee { EmployeeId = 1, Name = "John" },
       new Employee { EmployeeId = 2, Name = "Jane" }
   };

   var departments = new List<Department>
   {
       new Department { DepartmentId = 1, Name = "HR", EmployeeId = 1 },
       new Department { DepartmentId = 2, Name = "IT", EmployeeId = 2 }
   };

   var employeeDepartments = from e in employees
                             join d in departments on e.EmployeeId equals d.EmployeeId
                             select new { e.Name, DepartmentName = d.Name };

   foreach (var ed in employeeDepartments)
   {
       Console.WriteLine($"{ed.Name} works in {ed.DepartmentName}");
   }
   ```

7. **What is the difference between `First`, `FirstOrDefault`, `Single`, and `SingleOrDefault`?**
   - **Answer:**
     - `First`: Returns the first element of a sequence, throws an exception if no elements are found.
     - `FirstOrDefault`: Returns the first element of a sequence, or the default value if no elements are found.
     - `Single`: Returns the only element of a sequence, throws an exception if the sequence contains more than one element or none.
     - `SingleOrDefault`: Returns the only element of a sequence, or the default value if no elements are found. Throws an exception if the sequence contains more than one element.

### Advanced Questions

8. **How do you use LINQ to group data?**

   ```csharp
   var employees = new List<Employee>
   {
       new Employee { EmployeeId = 1, Name = "John", Department = "HR" },
       new Employee { EmployeeId = 2, Name = "Jane", Department = "IT" },
       new Employee { EmployeeId = 3, Name = "Joe", Department = "HR" }
   };

   var groupedEmployees = employees.GroupBy(e => e.Department);

   foreach (var group in groupedEmployees)
   {
       Console.WriteLine($"Department: {group.Key}");
       foreach (var employee in group)
       {
           Console.WriteLine($" - {employee.Name}");
       }
   }
   ```

9. **Explain the use of the `SelectMany` method with an example.**
   - **Answer:** `SelectMany` flattens a collection of collections into a single collection.

   ```csharp
   var employeeProjects = new List<Employee>
   {
       new Employee { Name = "John", Projects = new List<string> { "Project1", "Project2" } },
       new Employee { Name = "Jane", Projects = new List<string> { "Project3" } }
   };

   var allProjects = employeeProjects.SelectMany(e => e.Projects);

   foreach (var project in allProjects)
   {
       Console.WriteLine(project);
   }
   ```

10. **How do you perform a left join in LINQ?**

    ```csharp
    var employees = new List<Employee>
    {
        new Employee { EmployeeId = 1, Name = "John" },
        new Employee { EmployeeId = 2, Name = "Jane" }
    };

    var departments = new List<Department>
    {
        new Department { DepartmentId = 1, Name = "HR", EmployeeId = 1 }
    };

    var employeeDepartments = from e in employees
                              join d in departments on e.EmployeeId equals d.EmployeeId into ed
                              from d in ed.DefaultIfEmpty()
                              select new { e.Name, DepartmentName = d?.Name ?? "No Department" };

    foreach (var ed in employeeDepartments)
    {
        Console.WriteLine($"{ed.Name} works in {ed.DepartmentName}");
    }
    ```

These examples should give you a good understanding of how to use LINQ in .NET Core and prepare you for typical interview questions on the topic.