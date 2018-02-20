using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horse_tips
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var outname = FileGrab();
            var fileContents = ReadFile(outname);
            var output = ParseFile(fileContents); 

        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }

        }
        public static string[] ParseFile(string contents)
        {
            string splitString = "\n";
            string[] fileLines = contents.Split(new string[] { splitString }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in fileLines)
            {
                Console.WriteLine(line);
                string[] entry = line.Split(new string[] { ","}, StringSplitOptions.RemoveEmptyEntries);
                return entry;
            }
            return fileLines;

        }

        public static string FileGrab()
        {
            Console.WriteLine("Please hold, working!");
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "../../data.csv");
            return fileName;
        }

    }
}