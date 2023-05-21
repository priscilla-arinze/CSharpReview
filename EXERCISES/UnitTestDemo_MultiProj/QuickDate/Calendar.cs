using System;
using System.Runtime.CompilerServices;

// will need to add a reference from the specified project to this current project
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