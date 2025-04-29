using System.Runtime.InteropServices;

namespace GarbageCollectorDemo
{
    internal class ManagedObjectCleanedByGC
    {
    }

    internal class UnmanagedObjectNotCleanedByGC
    {
        List<IntPtr> allocatedBlocks = new List<IntPtr>();
        
        public UnmanagedObjectNotCleanedByGC(long i)
        {
            const int numBlocks = 1000;
            const int blockSizeInMB = 10;
            const int blockSizeInBytes = blockSizeInMB * 1024 * 1024;
            
            IntPtr ptr = Marshal.AllocHGlobal(blockSizeInBytes);
            // Optional: Write something to the memory to ensure it's committed
            unsafe
            {
                byte* bytePtr = (byte*)ptr.ToPointer();
                for (int j = 0; j < blockSizeInBytes; j += 4096) // write once per memory page
                    bytePtr[j] = 1;
            }
            allocatedBlocks.Add(ptr);

            Console.WriteLine($"Allocated {((i + 1) * blockSizeInMB)} MB total");
            System.Threading.Thread.Sleep(100); // Slow down to observe in Task Manager
        }
    }
    
    internal class UnmanagedObjectWithFinalizer
    {
        List<IntPtr> allocatedBlocks = new List<IntPtr>();
        
        public UnmanagedObjectWithFinalizer(long i)
        {
            const int numBlocks = 1000;
            const int blockSizeInMB = 10;
            const int blockSizeInBytes = blockSizeInMB * 1024 * 1024;
            
            IntPtr ptr = Marshal.AllocHGlobal(blockSizeInBytes);
            // Optional: Write something to the memory to ensure it's committed
            unsafe
            {
                byte* bytePtr = (byte*)ptr.ToPointer();
                for (int j = 0; j < blockSizeInBytes; j += 4096) // write once per memory page
                    bytePtr[j] = 1;
            }
            allocatedBlocks.Add(ptr);

            Console.WriteLine($"Allocated {((i + 1) * blockSizeInMB)} MB total");
            System.Threading.Thread.Sleep(100); // Slow down to observe in Task Manager
        }

        ~UnmanagedObjectWithFinalizer()
        {
            Console.WriteLine("Finalizer called. Releasing unmanaged memory...");

            foreach (var ptr in allocatedBlocks)
            {
                if (ptr != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(ptr);
                }
            }

            allocatedBlocks.Clear();
        }
    }
}
