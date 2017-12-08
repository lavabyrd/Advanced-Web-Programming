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

        static readonly string pathOut = @"/Users/mpreston/Documents/code/college/Advanced-Web-Programming/CA1/output.csv";
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
            var file = new FileInfo(fileName);
            Console.WriteLine(file);
            if(file.Exists) 
            {
                using(var reader = new StreamReader(fileName))
                {
                    Console.SetIn(reader);
                    Console.WriteLine(Console.ReadLine());
                }
            }
            else{
                Console.WriteLine("No file found!");
            }


        }




        private static void CreateSecondFile()
        {
            if (!File.Exists(pathOut))// same as if(File.Exists(FILE_PATH2) == false)
            {
                using (TextWriter txtWriter = File.CreateText(pathOut))
                {
                    txtWriter.WriteLine("File number 2");
                    txtWriter.Write('A');
                    txtWriter.WriteLine(" short story...");
                }
            }
        }

        private static void AppendText()
        {
            if (File.Exists(pathOut))
            {
                using (TextWriter txtWriter = File.AppendText(pathOut))
                {
                    txtWriter.WriteLine("Appended some text here");
                }
            }
        }



    }
}
