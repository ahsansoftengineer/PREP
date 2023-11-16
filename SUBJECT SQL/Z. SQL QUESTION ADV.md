
#### DIRTY READ
#### LOST UPDATE
#### NON REPEATABLE READS
#### PHONTOM READS
#### SNAPSHOT ISOLATIONS
#### DEADLOCK VICTOM
#### UNION VS INTERSECT
#### DLL Triggers
#### AUDIT TABLES
#### GROUPING
#### ROOLUP VS CUBE
#### RANK AND DENSE RANK
#### FUNCTIONS
- IIF
- IDENTITY VS SEQUENCE
- NTILE
- LEAD AND LEG
- FIRSTVALUE
- PIVOT TABLES
- TRYPARSE
- TRYCONVERT
- EOMONTH
- DATEFROMPARTS VS DATETIME2FROM
- OFFSETFETCH NEXT

#### WHERE VS HAVING
```sql
SELECT 
    column1, 
    column2, 
    aggregate_function(column3) AS aggregated_column
FROM 
    table1
JOIN 
    table2 ON table1.column_name = table2.column_name
WHERE 
    condition1 
    AND condition2
GROUP BY 
    column1, column2
HAVING 
    aggregate_function(column3) > some_value
ORDER BY 
    column_name ASC/DESC;
```

Explanation:

- `SELECT`: Specifies the columns you want to retrieve, including aggregate functions.
- `FROM`: Specifies the table from which to retrieve the data.
- `JOIN`: Specifies how to combine rows from different tables based on a related column.
- `ON`: Specifies the condition for the join.
- `WHERE`: Specifies conditions to filter the rows.
- `GROUP BY`: Groups the result set by one or more columns.
- `HAVING`: Filters the groups based on aggregate functions.
- `ORDER BY`: Specifies the sorting order for the result set.

Replace `column1, column2, ...` with the actual column names, `table1` and `table2` with the actual table names, `condition1, condition2` with the actual conditions for the `WHERE` clause, and `column_name` with the actual column name for joining and sorting. Also, replace `aggregate_function(column3)` with an actual aggregate function and column you want to perform the aggregation on.