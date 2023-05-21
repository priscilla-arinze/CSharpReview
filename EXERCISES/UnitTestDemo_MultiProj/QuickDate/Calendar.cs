using System;
using System.Runtime.CompilerServices;

// will have to add a reference from the specified project to this current project, 
// otherwise it will result in a "does not exist within this context" error in the other project
[assembly: InternalsVisibleToAttribute("QuickTest")] 

namespace QuickDate;

internal class Calendar
{
    static void Main(string[] args)
    {
        DateTime now = GetCurrentDate();
        Console.WriteLine($"Today's date is {now}");
        Console.ReadLine();
    }

    internal static DateTime GetCurrentDate()
    {
        return DateTime.Now.Date;
    }
}