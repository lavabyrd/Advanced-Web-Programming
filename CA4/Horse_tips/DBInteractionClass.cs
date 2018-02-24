using System;
using System.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Horse_tips
{
    public static class DBInteractionClass
    {
        // looks after the uploading of the CSV File. If files aleady exist, deletes all and then uploads the file
        public static void DbCSVUpload(BsonDocument docu)
        {
            MongoClient client = new MongoClient(ConfigurationManager.AppSettings["dbRWUser"]);
            IMongoDatabase database = client.GetDatabase("todompreston");
            IMongoCollection<BsonDocument> collec = database.GetCollection<BsonDocument>("TestHorseRaceCollection");

            collec.InsertOne(docu);
        }
        // checks the count of items in the collection
        public static void DbWipe()
        {
            MongoClient client = new MongoClient(ConfigurationManager.AppSettings["dbRWUser"]);
            IMongoDatabase database = client.GetDatabase("todompreston");
            IMongoCollection<BsonDocument> collec = database.GetCollection<BsonDocument>("TestHorseRaceCollection");
            long count = collec.Count(new BsonDocument());
            if (count > 1)
            {
                database.DropCollection("TestHorseRaceCollection");
                Console.WriteLine("deleting");
                Console.Read();
            }

        }
        // queries the collect and returns all item writing just the coursename
        public static async Task DbQuery() {
            MongoClient client = new MongoClient(ConfigurationManager.AppSettings["dbRUser"]);
            IMongoDatabase database = client.GetDatabase("todompreston");
            IMongoCollection<BsonDocument> collec = database.GetCollection<BsonDocument>("TestHorseRaceCollection");
            using (IAsyncCursor<BsonDocument> cursor = await collec.FindAsync(new BsonDocument()))
            {
                while (await cursor.MoveNextAsync())
                {
                    IEnumerable<BsonDocument> batch = cursor.Current;
                    foreach (BsonDocument document in batch)
                    {
                        // needs to check if nothing found
                        Console.WriteLine(document["CourseName"]);
                    }
                }
            }
        }
        // queries based on a choice of parameters
        public static async Task DbFilter() {
            MongoClient client = new MongoClient(ConfigurationManager.AppSettings["dbRUser"]);
            IMongoDatabase database = client.GetDatabase("todompreston");
            IMongoCollection<BsonDocument> collec = database.GetCollection<BsonDocument>("TestHorseRaceCollection");

            BsonDocument filter = new BsonDocument("Result", "true");

            await collec.Find(filter)
                .ForEachAsync(document => Console.WriteLine(document["CourseName"]));

        }

    }
}
