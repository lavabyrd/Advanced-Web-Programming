using System;
using System.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;



namespace Horse_tips
{
    public static class DBConnectionClass
    {
        public static string DbConnect(BsonDocument docu)
        {
            MongoClient client = new MongoClient(ConfigurationManager.AppSettings["dbURI"]);
            IMongoDatabase database = client.GetDatabase("todompreston");
            IMongoCollection<BsonDocument> collec = database.GetCollection<BsonDocument>("TestHorseRaceCollection");
            collec.InsertOne(docu);
            return "OK";
        }
    }
}
