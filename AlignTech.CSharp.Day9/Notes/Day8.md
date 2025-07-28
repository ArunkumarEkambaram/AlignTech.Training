Threading

Async Programming

Task Parallel Library

Async and Await







**Threading**

Threading in C# allows a program to execute multiple tasks concurrently, improving performance for operations like I/O-bound tasks, parallel computations, or background processing. It’s part of the System.Threading namespace and leverages the .NET runtime to manage threads.



A thread is the smallest unit of execution within a process.

C# programs start with a main thread, but you can create additional threads to perform tasks simultaneously.



**Uses:**

Running long-running tasks (e.g., file downloads) without freezing the UI.

Parallelizing CPU-intensive operations (e.g., calculations across multiple cores).

Managing asynchronous operations (though modern C# often uses async/await for this).



//Create a new thread

  Thread thread = new Thread(DoWork);

  thread.Start(); // Start the thread



Key Threading Concepts

* Thread: Represents an independent path of execution in a program. Each thread has its own stack but shares the same memory space (heap) with other threads in the process.
* Multithreading: Running multiple threads concurrently within a single process.
* Thread Safety: Ensuring shared resources (e.g., variables, objects) are accessed safely to avoid race conditions or data corruption.
* Synchronization: Mechanisms to coordinate thread execution and access to shared resources.
* Thread Pool: A managed pool of threads for efficient task execution, reducing the overhead of creating/destroying threads.



**Thread Pool**

Creating threads manually can be resource-intensive. The .NET thread pool manages a pool of reusable threads for short-lived tasks. Use ***ThreadPool.QueueUserWorkItem*** to schedule work



**Benefits**:

Reduces overhead of thread creation.

Automatically manages thread reuse and limits.



Example:

using System;

using System.Threading;



class Program

{

    static void Main()

    {

        ThreadPool.QueueUserWorkItem(DoWork, "Task 1");

        ThreadPool.QueueUserWorkItem(DoWork, "Task 2");



        Console.WriteLine("Main thread working...");

        Thread.Sleep(3000); // Wait for tasks to complete

        Console.WriteLine("Main thread done.");

    }



    static void DoWork(object state)

    {

        Console.WriteLine($"Worker thread ({state}) started...");

        Thread.Sleep(1000);

        Console.WriteLine($"Worker thread ({state}) done.");

    }

}



**Synchronization**

When multiple threads access shared resources, you need synchronization to prevent race conditions.

The ***lock*** keyword ensures only one thread accesses a critical section at a time.



**Disadvantages:**

* Deadlocks: Occur when two threads wait on each other’s locked resources. Avoid by ensuring consistent lock ordering.
* Race Conditions: Happen when threads access shared data without synchronization. Use locks or atomic operations.
* Thread Starvation: Too many threads can overwhelm the system, slowing execution. Use the thread pool to manage this.
* Overhead: Creating too many threads or frequent context switching reduces performance.



**Task Parallel Library(TPL)**

Mid-level abstraction for parallelism



The Task Parallel Library (TPL) in C# is a set of APIs in the System.Threading.Tasks namespace designed to simplify parallel and concurrent programming.

Introduced in .NET Framework 4.0, TPL provides a Mid-level abstraction over raw threads, making it easier to write scalable, efficient, and maintainable multithreaded applications.

It’s particularly suited for both CPU-bound and I/O-bound tasks



It simplifies:

* Parallel execution: Running multiple tasks simultaneously to utilize multiple CPU cores.
* Asynchronous programming: Handling I/O-bound operations without blocking threads.
* Task coordination: Managing dependencies, cancellations, and exceptions.



**Core Concepts**

* Task: Represents an asynchronous operation. Unlike threads, tasks are lightweight and managed by the .NET runtime.
* Thread Pool: TPL uses the thread pool to schedule tasks, avoiding the overhead of manual thread creation.
* Work Stealing: TPL uses a work-stealing scheduler to balance load across threads.
* Continuation: You can chain tasks using .ContinueWith() for sequential execution.
* Cancellation: Supports cooperative cancellation using CancellationToken.



**Patterns:**

1. Task Creating

 	- Uses the thread pool.

 	- Automatically starts execution.

2\. Parallel Class

 	- Ideal for data parallelism.

 	- Automatically partitions work across available cores.

3\. Parallel.Invoke

 	- Executes multiple independent actions concurrently.

4\. Parallel.ForEach

 	- Same operation on multiple data elements.

5\. Task Continuation

 	- Enables workflow chaining

6\. Cancellation Support

 	- Graceful cancellation using CancellationToken.



**When to Use TPL**

\- CPU-bound operations like Image processing, mathematical computations.

\- Running multiple independent jobs.

\- In background services or desktop apps.



Note:

Be cautious with parallelism, each request already runs on its own thread. Over-parallelizing can starve the thread pool.



**Example:**

using System;

using System;

using System.Collections.Generic;

using System.Threading.Tasks;



class Program

{

    static void Main()

    {

        List<string> items = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };



        // Using Parallel.ForEach

        Parallel.ForEach(items, item =>

        {

            Console.WriteLine($"Processing {item} on thread {Task.CurrentId}");

        });



        // Using Parallel.Invoke

        Parallel.Invoke(

            () => Console.WriteLine("Task 1"),

            () => Console.WriteLine("Task 2"),

            () => Console.WriteLine("Task 3")

        );



        // Using Task.Run with continuation

        Task.Run(() => {

            Console.WriteLine("Running background task...");

        }).ContinueWith(t => {

            Console.WriteLine("Task completed.");

        });



        Console.WriteLine("Main method complete.");

    }

}



Types of Parallelism



Data Parallelism

 Same operation on multiple data elements (e.g., Parallel.ForEach)

Task Parallelism

 Multiple independent tasks running concurrently (e.g., Parallel.Invoke)





What Is Asynchronous Programming?

Asynchronous programming allows your application to start a task and continue executing other code while waiting for that task to complete—without blocking the thread.

\- Ideal for I/O-bound operations: web requests, file access, database queries.

\- Keeps applications responsive, especially in UI or web environments.

\- Built around the async and await keywords.



Concepts:

**async**

Marks a method as asynchronous. Must return Task, Task<T>, or void.

async represents a method as an asynchronous method. It informs the calling method to continue its work

without waiting for the called method to return the control or the return value.

**await**

Pauses execution until the awaited task completes—without blocking.

If you want the calling asynchronous method to suspend its execution until the awaited task

completes, then you can use await keyword. Awaited task can be considered as the called method

execution. Note that an asynchronous method should have at least one await method call.

**Task**

Represents an asynchronous operation.

**Task<T>**

Represents an asynchronous operation that returns a value



**Example:**

public async Task<string> GetDataAsync()

{

    HttpClient client = new HttpClient();

    string result = await client.GetStringAsync("https://example.com");

    return result;

}



**Points to remember:**

TPL is the foundation for async programming in C#. The Task class is used for both parallel (CPU-bound) and asynchronous (I/O-bound) tasks. Async programming extends TPL with async/await for non-blocking I/O operations.



Both TPL and async programming rely on threads (via the thread pool) for execution. TPL abstracts thread management, and async programming further abstracts task scheduling for I/O tasks.



--All In One Demo---

&nbsp;internal class TPLAndAsync

&nbsp;{

&nbsp;    public async Task AllInOne()

&nbsp;    {

&nbsp;        //Async: I/O bound operation

&nbsp;        Task<string> downloadTask = DownloadAsync();



&nbsp;        //Thread: Low-Level threading

&nbsp;        Thread th = new Thread(() =>

&nbsp;        {

&nbsp;            Console.WriteLine($"Custom Thread is running.....");

&nbsp;            for (int i = 0; i < 5; i++)

&nbsp;            {

&nbsp;                Console.WriteLine($"Thread Value :{i + 1}\\t Thread Id :{Thread.CurrentThread.ManagedThreadId}");

&nbsp;                Thread.Sleep(1000);

&nbsp;            }

&nbsp;        });

&nbsp;         Task.Delay(2000);

&nbsp;        //Thread.Sleep(2000);

&nbsp;        //TPL: CPU bound operation

&nbsp;        Task cpuTask = Task.Run(() =>

&nbsp;        {

&nbsp;            Parallel.For(0, 5, i => Console.WriteLine($"TPL Computing :{i + 0}\\t Thread Id :{Task.CurrentId}"));

&nbsp;        });

&nbsp;      

&nbsp;        th.Start();



&nbsp;        //Wait for all the Task

&nbsp;        await Task.WhenAll(downloadTask, cpuTask);

&nbsp;        th.Join();



&nbsp;        Console.WriteLine($"Downloaded Content Length :{(await downloadTask).Length}");

&nbsp;    }



&nbsp;    static async Task<string> DownloadAsync()

&nbsp;    {

&nbsp;        using HttpClient client = new HttpClient();

&nbsp;        return await client.GetStringAsync("https://www.wikipedia.org/");

&nbsp;    }

&nbsp;}



