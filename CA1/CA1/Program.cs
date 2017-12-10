using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CA1
{
    class MainClass
    {

        //static readonly string pathOut = @"/Users/mpreston/Documents/code/college/Advanced-Web-Programming/CA1/output.csv";
        //static readonly string pathIn = @"/Users/mpreston/Documents/code/college/Advanced-Web-Programming/CA1/commit_changes.txt";

        public static void Main(string[] args)
        {

            //string[] lines = System.IO.File.ReadAllLines(pathIn);
            //int count = 0;
            //foreach (string line in lines)
            //{
            //    if (line == "------------------------------------------------------------------------")
            //    {
            //        count += 1;


            //        // in here we'll take the next line and run it through a split based on the 
            //        // " | " 
            //        // string[] tokens = str.Split(new[] { "is Marco and" }, StringSplitOptions.None);
            //        // this will give us an array we can apply to the class

            //    }
            //    else {
            //        count +=0;
            //    }
            //}
            //Console.WriteLine(count);
            //// Keep the console window open in debug mode.
            //Console.WriteLine("Press any key to exit.");
            //System.Console.ReadKey();

            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "commit_changes.txt");
            var fileContents = ReadFile(fileName);
            string splitString = "------------------------------------------------------------------------\n";
            string[] fileLines = fileContents.Split(new string[] { splitString }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in fileLines)
            {
                string[] commitLines = line.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var i in commitLines)
                {
                    Console.WriteLine(i);
                }
            }

        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName)){
                return reader.ReadToEnd();
            }
        }

        public static List<string[]> ReadCommitLines(string fileName) 
        {
            var lines = new List<string[]>();
            using (var reader = new StreamReader(fileName))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(new[] { " | " }, StringSplitOptions.None);
                    lines.Add(values);
                }
            }
            return lines;
        }

    }
}
