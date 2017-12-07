using System;
namespace CA1
{
    public class Commit
    {
        public string RevNum { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
        public string NoOfLines { get; set; }
        public string CommitMessage { get; set; }

        public Commit()
        {
            RevNum = "";
            Author = "";
            Date = "";
            NoOfLines = "";
            CommitMessage = "";
        }
    }
}
