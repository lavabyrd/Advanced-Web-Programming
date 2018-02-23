using System;
using MongoDB.Bson;
namespace Horse_tips
{

    public static class Upload
    {
        public static void EntryUpload() {
            Console.WriteLine("Upload data by Answering the following questions:");
            Console.WriteLine("Race Course Name:");
            string CourseName = Console.ReadLine();
            Console.WriteLine("Date Race was Ran (YYYY-MM-DD):");
            string DateRan = Console.ReadLine();
            Console.WriteLine("Amount Bet:");
            string Amount = Console.ReadLine();
            Console.WriteLine("Result:(won or lost)");
            string res = Console.ReadLine();



            bool result = ResCheck(res);

            BsonDocument docu = new BsonDocument{
                    {"CourseName", CourseName},
                    {"DateRan", DateRan},
                    {"AmountWon", Amount},
                    {"Result", result}
                };
            DBInteractionClass.DbCSVUpload(docu);
            Console.WriteLine("docu added " + docu);
            Startup.Start();
        }

        public static bool ResCheck(string res) {
            // check the res value, move to lower case and set to T or F
            string resLower = res.ToLower();
            Console.WriteLine(resLower + " this is res lower");

            if (resLower == "won")
            {
                return true;
            
            }
            else if (resLower == "lost")
            {
                return false;

            }
            else {
                Console.WriteLine("Sorry, I didn't understand the result, please try again");
                Startup.Start();

            }
            return false;

        }
    }
}
