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
            Console.WriteLine("Please hold, working!");
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "commit_changes.txt");
            var fileContents = ReadFile(fileName);
            string splitString = "------------------------------------------------------------------------\n";
            string[] fileLines = fileContents.Split(new string[] { splitString }, StringSplitOptions.RemoveEmptyEntries);


            foreach (var line in fileLines)
            {
                string[] commitLines = line.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                using (StreamWriter file =
                           new StreamWriter(@"/Users/mpreston/Documents/code/college/Advanced-Web-Programming/CA1/CA1/output.csv"))
                {
                    foreach (string s in fileLines)
                    {
                        
                        string l = s.Replace(",", "").Replace(" | ", ",").Replace("\n", "-").Replace("   ", " ");
                        file.WriteLine(l);

                    }

                }



            }
            Console.WriteLine("Finished");

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
