namespace AdvancedFileHandling;

class Program
{
    static void Main(string[] args)
    {
        FileInfoDemo.ExecutingAssemblyInfo();
        /* EXAMPLE OUTPUT:
            Information about file: AdvancedFileHandling.dll, 6144 bytes, last modified on 6/17/2023 12:56:26 PM - Full path: C:\Users\prisc\Documents\aa_CODE\aa_C#\CSharpReview\C# PROJECTS\AdvancedFileHandling\bin\Debug\net7.0\AdvancedFileHandling.dll
        */


        Console.WriteLine("\n\n");



        DirectoryInfoDemo.ExecutingAssemblyInfo();
        /* EXAMPLE OUTPUT:
            Information about file: AdvancedFileHandling.dll, 7168 bytes, last modified on 6/17/2023 1:45:20 PM - Full path: C:\Users\prisc\Documents\aa_CODE\aa_C#\CSharpReview\C# PROJECTS\AdvancedFileHandling\bin\Debug\net7.0\AdvancedFileHandling.dll

            Files:
                AdvancedFileHandling.deps.json (452 bytes)
                AdvancedFileHandling.dll (7168 bytes)
                AdvancedFileHandling.exe (154624 bytes)
                AdvancedFileHandling.pdb (11660 bytes)
                AdvancedFileHandling.runtimeconfig.json (147 bytes)
        */



        Console.WriteLine("\n\n");



        DirectoryInfoDemo.GetDirSubdirectories();
        /* EXAMPLE OUTPUT:
            Directories:
                Debug
        */



        Console.WriteLine("\n\n");



        DirectoryInfoDemo.ListSpecificFiles("*.cs");
        /* EXAMPLE OUTPUT:
            DirectoryInfoDemo.cs
            FileInfoDemo.cs
            MiniLogger.cs
            Program.cs
            StreamReaderDemo.cs
            StreamWriterDemo.cs
        */


        Console.WriteLine("\n\n");



        DirectoryInfoDemo.ListSpecificFiles("*Demo*");
        /* EXAMPLE OUTPUT:
            DirectoryInfoDemo.cs
            FileInfoDemo.cs
            StreamReaderDemo.cs
            StreamWriterDemo.cs
        */



        Console.WriteLine("\n\n");



        DirectoryInfoDemo.ListSpecificFilesRecursive("*.json");
        /* EXAMPLE OUTPUT:
            AdvancedFileHandling.csproj.nuget.dgspec.json
            project.assets.json
            AdvancedFileHandling.deps.json
            AdvancedFileHandling.runtimeconfig.json
        */


        Console.WriteLine("\n\n");



        MiniLogger.MiniLoggerDemo();
        /* EXAMPLE OUTPUT:
            Log Entry : 1:26:15 PM Saturday, June 17, 2023
            :
            :Test1
            -------------------------------

            Log Entry : 1:26:15 PM Saturday, June 17, 2023
            :
            :Test2
            -------------------------------
        */
    }
}
