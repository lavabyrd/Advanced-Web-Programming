using System;
using System.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;



namespace Horse_tips
{
    public static class DBConnectionClass
    {

        public static void DbCSVUpload(BsonDocument docu)
        {
            MongoClient client = new MongoClient(ConfigurationManager.AppSettings["dbURI"]);
            IMongoDatabase database = client.GetDatabase("todompreston");
            IMongoCollection<BsonDocument> collec = database.GetCollection<BsonDocument>("TestHorseRaceCollection");
            collec.InsertOne(docu);
            Console.WriteLine(docu);

        }

        public static long DbCount()
        {
            MongoClient client = new MongoClient(ConfigurationManager.AppSettings["dbURI"]);
            IMongoDatabase database = client.GetDatabase("todompreston");
            IMongoCollection<BsonDocument> collec = database.GetCollection<BsonDocument>("TestHorseRaceCollection");
            long pu = collec.Count(new BsonDocument());

            return pu;
        }


        public  static void DbQuery() {
            // check the db and get all current collections
        }
    }
}
