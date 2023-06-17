using System.IO;

namespace AdvancedFileHandling
{
    // Provides more info and capabilities for file handling relative to the File class
    // Best for performing multiple or more complex operations on files
    // Need to create an instance; it's not a bunch of static methods unlike File class
    public class FileInfoDemo
    {
        internal static void ExecutingAssemblyInfo()
        {
            FileInfo fi = new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if(fi != null)
            {
                Console.WriteLine(
                    string.Format(
                        "Information about file: {0}, {1} bytes, last modified on {2} - Full path: {3}",
                        fi.Name, fi.Length, fi.LastWriteTime, fi.FullName
                    )
                );
            }
            
        }
    }
}