using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MongoDB.Bson;

namespace Horse_tips
{
    class MainClass
    {
        

        public static void Main(string[] args)
        {
            Startup.Start();

            //string outname = FileControl.FileGrab();
            //string fileContents = FileControl.ReadFile(outname);
            //string[] output = FileControl.ParseFile(fileContents); 
        }
    }
}