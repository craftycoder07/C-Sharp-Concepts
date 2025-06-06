namespace GarbageCollectorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please press 1 for Demo of GC for managed objects");
            Console.WriteLine("Please press 2 for Demo of GC for primitive types");
            Console.WriteLine("Please press 3 for Demo of GC for unmanaged types");
            Console.WriteLine("Please press 4 for Demo of GC for managed types with finalizers");
            Console.WriteLine("Please press 5 for Demo of GC for managed types with IDisposable");
            string? selectedOption = Console.ReadLine();

            switch (selectedOption)
            {
                case "1":
                    //Demo GC for Managed objects
                    DemoGCForManagedObjects();
                    break;
                case "2":
                    //Demo GC for primitive types
                    DemoGCForPrmitiveTypes();
                    break;
                case "3":
                    //Demo GC for unmanaged types
                    DemoGCForUnmangedObjects();
                    break;
                case "4":
                    //Demo GC for managed types with finalizers
                    DemoGCForMamangedObjectsWithFinalizers();
                    break;
                case "5":
                    //Demo GC for managed types with finalizers
                    DemoGCForMamangedObjectsWithIDisposable();
                    break;
                default:
                    Console.WriteLine("Incorrect selection. Please run the app again.");
                    break;
            }
        }

        /// <summary>
        /// This method demonstrates how unreferenced managed objects are cleaned by GC.
        /// </summary>
        static void DemoGCForManagedObjects()
        {
            Console.WriteLine("Press enter to start GC for managed object demo");
            Console.ReadKey();
            for (long i = 0; i < 5000000; i++)
            {
                Console.WriteLine(i);

                /*
                 * This is managed object.
                 * As soon as for loop goes to next iteration object becomes unreferenced. (Becomes eligible for GC)
                 * GC won't immediately kick in.
                 * When there is strain on memory GC will collect unreferenced objects.
                 * In performance counter, you will see GC heap size going UP and DOWN indicating that unreferenced managed objects are cleaned by GC
                 */
                ManagedObjectCleanedByGC myClass = new ManagedObjectCleanedByGC();
            }
            Console.WriteLine("After FOR loop");
            Console.ReadKey();
        }

        /// <summary>
        /// This method demonstrates how primitives are allocated on stack and not cleaned by GC.
        /// </summary>
        static void DemoGCForPrmitiveTypes()
        {
            Console.WriteLine("Press enter to start GC for primitive type demo");
            Console.ReadKey();
            for (long i = 0; i < 2000000000000; i++)
            {
                /*
                 * This is primitive type. They live on 'Stack' memory hence not cleaned up by GC.
                 * You will very small change in size of heap memory unlike 'DemoGCForManagedObjects' where heap memory size changes drastically.
                 */
                int j = 0;
            }
            Console.WriteLine("After FOR loop");
            Console.ReadKey();
        }
        
        /// <summary>
        /// This method demonstrates how unmanaged objects not cleaned by GC even though they are allocated on heap.
        /// </summary>
        static void DemoGCForUnmangedObjects()
        {
            Console.WriteLine("Press enter to start GC for un-managed object demo");
            Console.ReadKey();
            for (long i = 0; i < 2000000; i++)
            {
                Console.WriteLine(i);

                /*
                 * This is un-managed object.
                 * As soon as for loop goes to next iteration object becomes unreferenced. (Becomes eligible for GC)
                 * When GC kick in, it will NOT collect unmanaged objects, leaving behind memory leak.
                 * In performance counter, you will see GC heap size won't change indicating that unmanaged objects are NOT cleaned by GC
                 */
                UnmanagedObjectNotCleanedByGC myClass = new UnmanagedObjectNotCleanedByGC(i);
            }
            Console.WriteLine("After FOR loop");
            Console.ReadKey();
        }
        
        /// <summary>
        /// This method demonstrates how having a finalizer in a managed object to clean unmanaged object delays GC.
        /// That object gets promoted to next GC heap level as GC gives managed object time to execute finalizer.
        /// Also this approach is not deterministic.
        /// </summary>
        static void DemoGCForMamangedObjectsWithFinalizers()
        {
            Console.WriteLine("Press enter to start GC for managed object demo with finalizers");
            Console.ReadKey();
            for (long i = 0; i < 5000000; i++)
            {
                Console.WriteLine(i);

                /*
                 * This is a managed object.
                 * As soon as for loop goes to next iteration object becomes unreferenced. (Becomes eligible for GC)
                 * When GC kick in, it will NOT collect managed objects, as it has finalizer.
                 * GC will give time to that object to execute finalizer and in meantime will promote it to next gen.
                 * In performance counter, you will see gen 0 & 1 heaps increasing and decreasing as it objects keep on promoting because of finalizers.
                 */
                ManagedObjectWithFinalizer myClass = new ManagedObjectWithFinalizer();
            }
            
            Console.WriteLine("After FOR loop");
            Console.ReadKey();
        }

        /// <summary>
        /// This method demonstrates how using IDisposable overcomes issues with destructor.
        /// Also, this approach is deterministic.
        /// </summary>
        static void DemoGCForMamangedObjectsWithIDisposable()
        {
            Console.WriteLine("Press enter to start GC for managed object demo with IDisposable");
            Console.ReadKey();
            for (long i = 0; i < 5000000; i++)
            {
                Console.WriteLine(i);

                /*
                 * This is a managed object.
                 * As soon as for loop goes to next iteration object becomes unreferenced. (Becomes eligible for GC)
                 * When GC kick in, As we are using 'using' statement, 'Dispose' method is executed cleaning up all the resources.
                 * Thus, resources don't get promoted to next gen.
                 * In performance counter, you will see gen 0 heaps increasing and decreasing as it objects keep on getting cleared.
                 * One issue with this approach is developer forgets to use 'using', object won't be cleared causing memory leak.
                 * Thus, you want to have a backup with destructor just in case developer forgets to use 'using'
                 */
                using ManagedObjectWithIDisposable myClass = new ManagedObjectWithIDisposable();
            }
            
            Console.WriteLine("After FOR loop");
            Console.ReadKey();
        }
    }
}
