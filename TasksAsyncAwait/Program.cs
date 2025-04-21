/*
 * Initially computers were single threaded. Single threads was used for all purposes, like UI and any other tasks.
 * Now if that one thread is performing long-running task, it won't be able to respond to UI inputs. Basically it will block the UI.
 * For this reason multithreading was introduced. (Threads in C#)
 */
 
Console.WriteLine("Long-running task Blocking thread. Press any key for demo.");
Console.ReadKey();
//Assume following is a long-running task. In this case main thread will be blocked and user experience will be ruined.
//Below demo will print 'Before Thread' then WAIT for long-running task to finish and then print 'After Thread'. Blocking behaviour.
Console.WriteLine("Before thread.");
Thread.Sleep(10000);
Console.WriteLine("After thread.");


Console.WriteLine("Long running task offloaded to a thread for NON blocking thread. Press any key for demo.");
Console.ReadKey();
//With threads, developers can offload long-running task to other thread, which will not block the main thread (UI-thread)
//Below demo will print 'Before Thread' and then immediately print 'After Thread' and won't wait for long-running task to finish. NON blocking behaviour.
Console.WriteLine($"Before Thread");
new Thread(() =>
{
    Thread.Sleep(10000);
    Console.WriteLine($"Inside Thread with id =>{Thread.CurrentThread.ManagedThreadId}");
}).Start();
Console.WriteLine($"After Thread");


/*
 * Problem with threads is that they run asynchronously which can alter the perceived flow of the program.
 * Plus they don't have return type, so it is difficult to return value from threads.
 * To overcome these issues 'Task' were introduced.
 * Behind the scenes, Task also uses threads.
 */

//With the help of task, developers can return a value just like we do in regular method.
Console.WriteLine("Task Example. Press any key for demo.");
Console.ReadKey();
Console.WriteLine($"Before Task");
var result = Task.Run<string>(() =>
{
    Thread.Sleep(10000);
    return $"Id of thread running task is {Thread.CurrentThread.ManagedThreadId}";
});
Console.WriteLine(result);
Console.WriteLine($"After Task");


//Above example would still execute long-running task out of perceived order.
//To overcome this issue, async & await were introduced.
Console.WriteLine("Task with AWAIT Example. Press any key for demo.");
Console.ReadKey();
Console.WriteLine($"Before Task With AWAIT Example.");
var result1 = await Task.Run<string>(() =>
{
    Thread.Sleep(10000);
    return $"Id of thread running task is {Thread.CurrentThread.ManagedThreadId}";
});
Console.WriteLine(result1);
Console.WriteLine($"After Task With AWAIT Example.");