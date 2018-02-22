using System;
using MongoDB.Bson;
namespace Horse_tips
{
    public class Upload
    {
        public static void EntryUpload() {
            BsonDocument docu = new BsonDocument{
                    {"CourseName", CourseName},
                    {"DateRan", DateRan},
                    {"AmountWon", AmountWon},
                    {"Result", Result}
                };
            DBInteractionClass.DbCSVUpload(docu);
            Console.WriteLine(CourseName + " Added");
        }
    }
}
