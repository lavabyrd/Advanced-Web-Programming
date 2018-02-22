using System;
namespace Horse_tips
{
    public class Startup
    {
        public static string Start() {
            Console.WriteLine("Welcome to the Horse Tips App");
            Console.WriteLine("To see whats currently listed, select one of the following: ");
            Console.WriteLine("1: View current stored data");
            Console.WriteLine("2: Remove current data from the database");
            Console.WriteLine("3: Re-upload the CSV File again");
            Console.WriteLine("4: Exit");
            string answer = Console.ReadLine();

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
                    Console.WriteLine(parseAnswer);
                    Console.WriteLine("Good work!");
                    Start();
                    return parseAnswer.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error is " + ex);
                Start();
                return "ok";
            }
        }
    }
}
