## TIME COMPLEXITY

### SORTING ALOG 
|Sorting Algorithm |    Best Case     |   Average Case   |    Worst Case    |
|------------------|------------------|------------------|------------------|
|Selection Sort    |       Ω(n²)      |      θ(n²)       |       O(n²)      |
|Bubble Sort       |       Ω(n)       |      θ(n²)       |       O(n²)      |
|Insertion Sort    |       Ω(n)       |      θ(n²)       |       O(n²)      |
|Merge Sort        |   Ω(n logn(n))   |   θ(n logn(n))   |   O(n logn(n))   |
|Quick Sort        |   Ω(n logn(n))   |   θ(n logn(n))   |       O(n²)      |
|Heap Sort         |   Ω(n logn(n))   |   θ(n logn(n))   |   O(n logn(n))   |
|Radix Sort        |      Ω(nk)       |      θ(nk)       |       O(nk)      |
|Bucket Sort       |     Ω(n + k)     |     θ(n + k)     |       O(n²)      |
-----------------------------------------------------------------------------

Time complexity is a way to measure the efficiency of an algorithm in terms of the time it takes to run as a function of the size of its input. It's an important aspect of computer science and software engineering, as it helps to predict the performance of algorithms and to make decisions about which algorithms to use based on their efficiency.

## Big O Notation

Big O notation is the most commonly used notation to describe time complexity. It provides an upper bound on the growth rate of an algorithm's running time, which helps to classify algorithms according to their performance.

### Common Time Complexities

1. **Constant Time – O(1)**: The running time is constant and does not change with the size of the input.
   ```python
   def constant_time_example(array):
       return array[0]
   ```

2. **Logarithmic Time – O(log n)**: The running time increases logarithmically with the size of the input.
   ```python
   def logarithmic_time_example(n):
       while n > 1:
           n = n // 2
   ```

3. **Linear Time – O(n)**: The running time increases linearly with the size of the input.
   ```python
   def linear_time_example(array):
       for item in array:
           print(item)
   ```

4. **Log-Linear Time – O(n log n)**: The running time increases log-linearly with the size of the input.
   ```python
   def log_linear_time_example(array):
       return sorted(array)
   ```

5. **Quadratic Time – O(n^2)**: The running time increases quadratically with the size of the input.
   ```python
   def quadratic_time_example(array):
       for i in array:
           for j in array:
               print(i, j)
   ```

6. **Cubic Time – O(n^3)**: The running time increases cubically with the size of the input.
   ```python
   def cubic_time_example(array):
       for i in array:
           for j in array:
               for k in array:
                   print(i, j, k)
   ```

7. **Exponential Time – O(2^n)**: The running time doubles with each additional element in the input.
   ```python
   def exponential_time_example(n):
       if n == 0:
           return 1
       else:
           return exponential_time_example(n-1) + exponential_time_example(n-1)
   ```

8. **Factorial Time – O(n!)**: The running time increases factorially with the size of the input.
   ```python
   def factorial_time_example(n):
       if n == 0:
           return 1
       else:
           return n * factorial_time_example(n-1)
   ```

### Why Time Complexity Matters

1. **Efficiency**: Understanding time complexity helps to choose the most efficient algorithm for a given problem, especially for large inputs.
2. **Scalability**: It helps predict how an algorithm will scale with increasing input sizes, which is crucial for designing systems that handle large amounts of data.
3. **Performance Tuning**: It aids in identifying bottlenecks in algorithms and optimizing code for better performance.

### Practical Examples

- **Searching**: Linear search has O(n) complexity, while binary search has O(log n) complexity.
- **Sorting**: Bubble sort and insertion sort have O(n^2) complexity, while quicksort and mergesort have O(n log n) complexity.
- **Graph Algorithms**: Dijkstra’s algorithm for shortest paths has O(V^2) complexity with a simple implementation, where V is the number of vertices.

Understanding and analyzing time complexity is essential for writing efficient algorithms and optimizing existing code.