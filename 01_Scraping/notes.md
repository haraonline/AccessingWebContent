
## Async Void is a problem


Using "async void methods" is discouraged because they do not allow the caller to wait for their completion or handle
any errors that occur within them. In this specific case, it means that the application may exit before the HTTP request
is completed or any exceptions that occur during the request handling are propagated.

If the Main method in C# is synchronous, meaning that it returns before
all the tasks it initiates are completed. Therefore, it is not recommended to use "async void" for the Main method.
Instead, you should use async Task or async Task<int> as the return type


## The Task class

In C#, the Task class "represents an asynchronous operation or a unit of work" that can be executed asynchronously.
It is a fundamental part of the Task Parallel Library (TPL) and is commonly used to perform time-consuming or I/O-bound
operations in a non-blocking way

Here are some common use cases for the Task class:

- Asynchronously executing a method or function and obtaining its result using the Task<T> class, 
  which returns a Task object that represents the asynchronous operation and a T object that represents the result of the operation.

- Chaining asynchronous operations using the ContinueWith method, which allows you to specify a delegate that will be executed when
  the previous Task completes.

- Combining multiple Task objects into a single Task using the Task.WhenAll or Task.WhenAny methods to wait for multiple operations to complete.
- Running asynchronous operations in parallel using the Parallel class or the Parallel.ForEach method.

  Overall, the Task class provides a powerful and flexible way to manage asynchronous operations in C#, 
  making it easier to write high-performance and responsive applications