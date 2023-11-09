### IQuerable vs IEnumerable
- `IQueryable` and `IEnumerable` are both interfaces in C# that are related to querying collections of data, but they serve different purposes and have distinct characteristics:

1. **IEnumerable**:
   - It is part of the `System.Collections` namespace.

2. **IQueryable**:
   - It is part of the `System.Linq` namespace and is typically used in LINQ queries against a database using Entity Framework or other ORM

- Use `IEnumerable` when working with in-memory collections or when you have already retrieved data from an external source, and you want to perform in-memory operations like filtering and transformation.
- Use `IQueryable` when working with data that is still in a remote data source, and you want to build complex queries that can be executed efficiently on the server, such as in a database. This is particularly useful when using ORM frameworks like Entity Framework for database queries.

### IList vs IEnumerable
- IEnumerable represents a forward-only cursor of items, allowing you to iterate through the items in a collection one at a time.
- IEnumerable does not provide methods for adding, modifying, or removing elements in the collection. It's a read-only interface.
- IList is more feature-rich and extends the IEnumerable interface.
It inherits all the capabilities of IEnumerable for reading data and adds methods for modifying the collection, such as adding, removing, and modifying elements.