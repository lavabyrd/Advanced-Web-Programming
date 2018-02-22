using System;
using System.Threading.Tasks;
namespace Horse_tips
{
    public static class Startup
    {
        public static void Start()
        {
            Console.WriteLine("Welcome to the Horse Tips App");
            Console.WriteLine("To see whats currently listed, select one of the following: ");
            Console.WriteLine("1: View current stored data");
            Console.WriteLine("2: Remove current data from the database");
            Console.WriteLine("3: Re-upload the CSV File again");
            Console.WriteLine("4: Exit");
            string answer = Console.ReadLine();

            Selection(answer);
        }


        public static void Selection(string answer)
        {
            try
            {
                int parseAnswer = int.Parse(answer);
                if (parseAnswer < 1 || parseAnswer > 4)
                {
                    Console.WriteLine("Try another Selection");
                    Start();
                }
                else
                {
                    
                    TakeAction(parseAnswer);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error is " + ex);
                Start();
            }
        }


        public static void TakeAction(int parseAnswer) {
            if (parseAnswer == 1)
            {
                Task x = DBConnectionClass.DbQuery();
                //Console.WriteLine(x);
                Console.Read();
                Start();
            }
            else if (parseAnswer == 2)
            {
                Console.WriteLine("not currently implemented");
                Console.WriteLine("back to the start we go!");
                Start();
            }
            else if (parseAnswer == 3)
            {
                string outname = FileControl.FileGrab();
                string fileContents = FileControl.ReadFile(outname);
                string[] output = FileControl.ParseFile(fileContents);
                Console.WriteLine("upload done!");
                Console.WriteLine("back to the start we go!");
                Start();
            }
            else
            {
                Environment.Exit(1);
            }
        }
    }
}
