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
    
    internal class ManagedObjectWithFinalizer
    {
        private IntPtr _unmanagedResource;

        public ManagedObjectWithFinalizer()
        {
            _unmanagedResource = Marshal.AllocHGlobal(10);
        }
        
        ~ManagedObjectWithFinalizer()
        {
            Marshal.FreeHGlobal(_unmanagedResource);
        }
    }

    internal class ManagedObjectWithIDisposable : IDisposable
    {
        // A pointer to 10 bytes allocated on the unmanaged heap.
        private IntPtr _unmanagedResource;

        public ManagedObjectWithIDisposable()
        {
            _unmanagedResource = Marshal.AllocHGlobal(10);
        }
        
        public void Dispose()
        {
            Marshal.FreeHGlobal(_unmanagedResource);
            GC.SuppressFinalize(this);
        }

        ~ManagedObjectWithIDisposable()
        {
            Marshal.FreeHGlobal(_unmanagedResource);
        }
    }

    internal class DisposePatternDemo : IDisposable
    {
        private IntPtr _unmanagedResource;
        private MemoryStream _unmanagedStream;
        private bool _disposed;

        public DisposePatternDemo()
        {
            _unmanagedResource = Marshal.AllocHGlobal(10);
            _unmanagedStream = new();
        }

        /// <summary>
        /// Dispose pattern takes advantage of finalizer and IDisposable.
        /// If developer forgets to call 'Dispose', destructor will take care of clearing objects.
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                _unmanagedStream.Dispose();
                _unmanagedStream = null;
            }
            
            Marshal.FreeHGlobal(_unmanagedResource);
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~DisposePatternDemo()
        {
            Dispose(false);
        }
    }
}
