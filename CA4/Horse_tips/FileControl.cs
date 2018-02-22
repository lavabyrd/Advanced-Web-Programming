using System;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MongoDB.Driver;
using MongoDB.Bson;
namespace Horse_tips
{
    
    public static class FileControl
    {
        
        public static string FileGrab()
        {
            Console.WriteLine("Please hold, working!");
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "../../data.csv");
            return fileName;
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
                string l = line.Replace("(", "").Replace(")", ",").Replace(" ", "");
                string[] entry = l.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                // take each entry and do something
                string CourseName = entry[0];
                string DateRan = entry[1] + "-" + entry[2] + "-" + entry[3];
                string AmountWon = entry[4];
                string Result = entry[5];

                BsonDocument docu = new BsonDocument{
                    {"CourseName", CourseName},
                    {"DateRan", DateRan},
                    {"AmountWon", AmountWon},
                    {"Result", Result}
                };
                DBConnectionClass.DbCSVUpload(docu);
                Console.WriteLine(CourseName + " Added");
            }
            return fileLines;

        }
    }
}
