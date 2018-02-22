using System;
using System.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Horse_tips
{
    public static class DBConnectionClass
    {

        public static void DbCSVUpload(BsonDocument docu)
        {
            MongoClient client = new MongoClient(ConfigurationManager.AppSettings["dbURI"]);
            IMongoDatabase database = client.GetDatabase("todompreston");
            // needs to be renamed as may cause categorization error
            IMongoCollection<BsonDocument> collec = database.GetCollection<BsonDocument>("TestHorseRaceCollection");
            collec.InsertOne(docu);


        }

        public static long DbCount()
        {
            MongoClient client = new MongoClient(ConfigurationManager.AppSettings["dbURI"]);
            IMongoDatabase database = client.GetDatabase("todompreston");
            IMongoCollection<BsonDocument> collec = database.GetCollection<BsonDocument>("TestHorseRaceCollection");
            long pu = collec.Count(new BsonDocument());

            return pu;
        }

        public static async Task DbQuery() {
            MongoClient client = new MongoClient(ConfigurationManager.AppSettings["dbURI"]);
            IMongoDatabase database = client.GetDatabase("todompreston");
            IMongoCollection<BsonDocument> collec = database.GetCollection<BsonDocument>("TestHorseRaceCollection");
            using (IAsyncCursor<BsonDocument> cursor = await collec.FindAsync(new BsonDocument()))
            {
                while (await cursor.MoveNextAsync())
                {
                    IEnumerable<BsonDocument> batch = cursor.Current;
                    foreach (BsonDocument document in batch)
                    {
                        Console.WriteLine(document["CourseName"]);
                    }
                }
            }
        }


    }
}
