using System;

namespace CA1
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string[] lines = System.IO.File.ReadAllLines(@"/Users/mpreston/Documents/code/college/Advanced-Web-Programming/CA1/commit_changes.txt");
            int count = 0;
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                //Console.WriteLine("\t" + line);
                if (line == "------------------------------------------------------------------------")
                {
                    count += 1;
                }
                else {
                    count +=0;
                }
            }
            Console.WriteLine(count);
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
