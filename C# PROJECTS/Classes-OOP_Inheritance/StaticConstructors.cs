using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_OOP_Inheritance
{
    public class StaticConstructors
    {
        // Static variable that must be initialized at run time.
        static readonly long baseline;


        // Static constructors are called at most one time, invoked before the first instance constructor is run or before any member is accessed.
        // CANNOT be inherited by other classes nor overloaded
        // CANNOT be called directly, unlike static methods; will be invoked automatically by CLR upon instance creation
        // EXAMPLE USAGES:
            // for classes being able to write entries to a log file
            // for creating wrapper classes for unmanaged code (code that is not specifically designated for the .NET Framework)
            // for performing run-time checks for type parameters that cannot be appropriately checked with compile-time type-parameter constaints
        static StaticConstructors()
        {
            baseline = DateTime.Now.Ticks;
        }
    }
}