using System.IO;

namespace AdvancedFileHandling
{
    public class DirectoryInfoDemo
    {
        internal static void ExecutingAssemblyInfo()
        {
            DirectoryInfo di = new DirectoryInfo(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
        
            if(di != null)
            {
                FileInfo[] subFiles = di.GetFiles();

                if(subFiles.Length > 0)
                {
                    Console.WriteLine("Files:");
                    foreach(FileInfo subFile in subFiles)
                    {
                        Console.WriteLine("   " + subFile.Name + " (" + subFile.Length + " bytes)");
                    }
                }
            }
        }

        internal static void GetDirSubdirectories()
        {
            DirectoryInfo di = new DirectoryInfo("C:/Users/prisc/Documents/aa_CODE/aa_C#/CSharpReview/C# PROJECTS/AdvancedFileHandling/obj");
            
            DirectoryInfo[] subDirs = di.GetDirectories();
            
            if(subDirs.Length > 0)
            {
                Console.WriteLine("Directories:");
                foreach(DirectoryInfo subDir in subDirs)
                {
                    Console.WriteLine("   " + subDir.Name);
                }
            }
        }

        /// <summary>
        /// Example pattern match: "*.exe"
        /// </summary>
        internal static void ListSpecificFiles(string patternmatch)
        {
            DirectoryInfo di = new DirectoryInfo("C:/Users/prisc/Documents/aa_CODE/aa_C#/CSharpReview/C# PROJECTS/AdvancedFileHandling");

            FileInfo[] subfiles = di.GetFiles(patternmatch);

            foreach(FileInfo file in subfiles)
            {
                Console.WriteLine(file.Name);
            }
        }

        /// <summary>
        /// Example pattern match: "*.exe"
        /// </summary>
        internal static void ListSpecificFilesRecursive(string patternmatch)
        {
            DirectoryInfo di = new DirectoryInfo("C:/Users/prisc/Documents/aa_CODE/aa_C#/CSharpReview/C# PROJECTS/AdvancedFileHandling");

            FileInfo[] subfiles = di.GetFiles(patternmatch, SearchOption.AllDirectories);

            foreach(FileInfo file in subfiles)
            {
                Console.WriteLine(file.Name);
            }
        }
    }
}