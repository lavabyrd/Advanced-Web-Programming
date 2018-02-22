using System;
namespace Horse_tips
{
    public class Startup
    {
        public static string Start()
        {
            Console.WriteLine("Welcome to the Horse Tips App");
            Console.WriteLine("To see whats currently listed, select one of the following: ");
            Console.WriteLine("1: View current stored data");
            Console.WriteLine("2: Remove current data from the database");
            Console.WriteLine("3: Re-upload the CSV File again");
            Console.WriteLine("4: Exit");
            string answer = Console.ReadLine();

            Selection(answer);
            return null;

        }


        public static string Selection(string answer)
        {
            try
            {
                int parseAnswer = int.Parse(answer);
                if (parseAnswer < 1 || parseAnswer > 4)
                {
                    Console.WriteLine("Try another Selection");
                    Start();
                    return "ok";
                }
                else
                {
                    Console.WriteLine("Good work!");
                    TakeAction(parseAnswer);
                    return parseAnswer.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error is ");
                Start();
                return "ok";
            }
        }


        public static string TakeAction(int parseAnswer) {
            if (parseAnswer == 1)
            {
                Console.WriteLine("not currently implemented");
                Console.WriteLine("Back to the start we go");
                Start();
                return null;
            }
            else if (parseAnswer == 2)
            {
                Console.WriteLine("not currently implemented");
                Console.WriteLine("back to the start we go!");
                Start();
                return null;
            }
            else if (parseAnswer == 3)
            {
                string outname = FileControl.FileGrab();
                string fileContents = FileControl.ReadFile(outname);
                string[] output = FileControl.ParseFile(fileContents);
                Console.WriteLine("upload done!");
                Console.WriteLine("back to the start we go!");
                Start();
                return null;
            }
            else
            {
                Environment.Exit(1);
                return null;
            }
        }
    }
}
