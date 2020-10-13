using System.IO;
using System;

namespace FileDirectoryHandling
{
    public class FileIO
    {
        public void LearnFileHandling()
        {
            string fileContent = File.ReadAllText(@"D:\Fon\t.txt");
            Console.WriteLine(fileContent);

        }
        public void LearnFileWriting()
        {
            File.WriteAllText("A.txt", "This is the file. \n Written by me");

        }

        public void LearnFileInfo()
        {
            FileInfo fileInfo = new FileInfo("A.txt");
            var fileLength = fileInfo.Length;
            var fileCreationTime = fileInfo.CreationTime;
            var fileDirectory = fileInfo.Directory;
            Console.WriteLine($"File Size: {fileLength} bytes");
            Console.WriteLine($"File Created: {fileCreationTime}");
            Console.WriteLine($"File Directory: {fileDirectory}");
        }

        internal void LearnDirectory()
        {
            Directory.CreateDirectory("Demo");
            File.WriteAllText("Demo/dipan.db","The new file. ");
        }

        internal void LearnDirectoryInfo()
        {
            string folderPath = "/Users/xxxx/dpn/6th sem/Net Centric Programming/CSharpbasics";
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            var files = dir.GetFiles();
            Console.WriteLine($"No Of Files: {files.Length}");

        }
    }
}