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
                using (StreamWriter file = new StreamWriter("../../output.csv"))
                {
                    file.WriteLine("Revision ID,Author,Date Submitted,Commit Lines and Commit Messages");
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

    }
}
