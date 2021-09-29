using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace GarbageCollection
{
    class Employee:IDisposable
    {
        public Employee()
        {

        }

        //  Destructor also called Finalize method.
        ~Employee()
        {
            GC.Collect();
            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Debug.WriteLine("Destructor Invoked");
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
