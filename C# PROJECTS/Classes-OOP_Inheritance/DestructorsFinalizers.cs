using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_OOP_Inheritance
{
    public class DestructorsFinalizers
    {
        // Finalizer (or 'destuctors'): final stuff to do when instance is collected by the garbage collector
        // CONSIDERATIONS:
            // CANNOT be defined in structs, ONLY classes
            // CAN only have one finalizer per class
            // CANNOT be inherited, but can have a transitive effect
            // CANNOT be overloaded
            // CANNOT be called directory, will be invoked automatically upon instance de-referencing
            // CANNOT take modifiers nor have parameters
            // Use only if necessary, otherwise every single instance that gets de-referenced with have to execute the base Finalize() method
                // from the base Object class and might be needlessly performance-intensive
        ~DestructorsFinalizers() 
        {
            // any cleanup statements...
            Console.WriteLine("clean up and stuff...");
        }


        // The above constructor can also be defined like this w/ an expression body definition:
        // ~DestructorsFinalizers() => Console.WriteLine("clean up and stuff...");
    }
}