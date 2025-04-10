/*
 * Threads are the smallest unit of the program used to execute independent actions in parallel.
 * They run asynchronously, meaning once they start executing, program (main thread) doesn't wait for it to finish execution.
 * Order of thread execution is non-deterministic. Program
 */

//Creating thread (Using thread constructor)
Thread t1 = new Thread(() =>
//Method/Action (lambda) that is executed by thread, independent of the main thread. 
{
    Thread.Sleep(15000);
    Console.WriteLine($"Inside Thread 1 with id =>{Thread.CurrentThread.ManagedThreadId}");
});

/*
 * BACKGROUND THREADS
 * By default, all threads are foreground. You can make them background by setting IsBackground property to true.
 * If thread is background, then console won't stop for it to finish its execution. (If you run the program you won't see the output for t1 thread)
 */
t1.IsBackground = true;

/*
 * STARTING THREAD
 * As threads execute asynchronously, after calling 'start' method program counter moves to next statement.
 */
t1.Start();

new Thread(() => {
    Thread.Sleep(1000);
    Console.WriteLine($"Inside Thread 2 with id =>{Thread.CurrentThread.ManagedThreadId}");
}).Start();

new Thread(() => {
    Thread.Sleep(1000);
    Console.WriteLine($"Inside Thread 3 with id =>{Thread.CurrentThread.ManagedThreadId}");
}).Start();


Console.WriteLine($"Inside Thread 4 with id =>{Thread.CurrentThread.ManagedThreadId}");

//Spawning a thread is a costly operation. Developers can use thread pool to solve that problem.
for (int i = 0; i < 1000; i++)
{
    //WITHOUT ThreadPool
    // new Thread(() => {
    //     Console.WriteLine($"Before Thread with id =>{Thread.CurrentThread.ManagedThreadId}");
    //     Thread.Sleep(1000);
    //     Console.WriteLine($"After Thread with id =>{Thread.CurrentThread.ManagedThreadId}");
    // }).Start();
    
    //WITH ThreadPool. In the output you can see, threads being reused. 
    ThreadPool.QueueUserWorkItem((o) =>
    {
        Console.WriteLine($"Before Thread with id =>{Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(1000);
        Console.WriteLine($"After Thread with id =>{Thread.CurrentThread.ManagedThreadId}");
    });
}

//Thread.Join waits for execution of the thread to finish. () 
Thread t2 = new Thread(() =>
{
    Thread.Sleep(1000);
    Console.WriteLine($"After Thread with id =>{Thread.CurrentThread.ManagedThreadId}");
});
t2.Start();
t2.Join();

Console.ReadKey();