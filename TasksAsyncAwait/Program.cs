/*
 * WHAT IS ASYNCHRONOUS?
 * You start something and don't wait for it to finish.
 */
 
//THREAD ISSUES
//ISSUE-1: Threads are async. (If you look at the output it's not sequential.)
Console.WriteLine($"Before thread");
new Thread(() =>
{
    Thread.Sleep(500);
    Console.WriteLine($"Inside thread");
}).Start();
Console.WriteLine($"After thread");

/*
 * To solve that issue, developers can use 'blocking wait' concept.
 * Problem with that is it blocks the main thread which is a big issue in UI applications.
 */
Thread t1 = new Thread(() =>
{
    Thread.Sleep(500);
    Console.WriteLine($"Inside thread 1");
});
t1.Start();
t1.Join();

/*
 * To overcome these issues we have tasks.
 * It is a promise that work will finish in the future.
 * It is an actual object.
 * Any method that returns Task can be awaited.
 * Tasks MAY use threads from thread pool to execute operation.
 */
Console.WriteLine($"Before Task");
await Task.Run(() =>
{
    Task.Delay(500);
    Console.WriteLine($"Inside Task");
});
Console.WriteLine($"After Task");

static void PrintTask()
{
    Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");
    Console.WriteLine($"Print Task method");
}

//Another way of calling task.
Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");
Console.WriteLine($"Before Task 2");
Task t2 = new Task(PrintTask);
t2.Start();
await t2;
Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");
Console.WriteLine($"After Task 2");

Console.ReadLine();



