using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Horse_tips
{
    class MainClass
    {


        public static void Main(string[] args)
        {
            string db = ConfigurationManager.AppSettings["dbURI"];

            string outname = FileGrab();
            string fileContents = ReadFile(outname);
            string[] output = ParseFile(fileContents, db); 
        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }

        }



        public static string[] ParseFile(string contents, string db)
        {
            MongoClient client = new MongoClient(db);
            IMongoDatabase database = client.GetDatabase("todompreston");
            IMongoCollection<BsonDocument> collec = database.GetCollection<BsonDocument>("TestHorseRaceCollection");

            string splitString = "\n";
            string[] fileLines = contents.Split(new string[] { splitString }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in fileLines)
            {
                string l = line.Replace("(", "").Replace(")", ",").Replace(" ", "");
                string[] entry = l.Split(new string[] { ","}, StringSplitOptions.RemoveEmptyEntries);
                // take each entry and do something
                string CourseName = entry[0];
                string DateRan = entry[1] + "-" + entry[2] + "-" + entry[3];
                string AmountWon = entry[4];
                string Result = entry[5];

                var docu = new BsonDocument{
                    {"CourseName", CourseName},
                    {"DateRan", DateRan},
                    {"AmountWon", AmountWon},
                    {"Result", Result}
                };

                collec.InsertOne(docu);
                //Console.Read();
                Console.WriteLine(CourseName + " Added");




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