using System;
using MongoDB.Driver;

namespace Tests
{
    public static class TestMongoDatabase
    {
        public static IMongoDatabase Create()
        {
            var mongoConnectionString = Environment.GetEnvironmentVariable("PROJECT5100_MONGO_CONNECTION_STRING")
                                        ?? "mongodb+srv://prefie:fiit2021@cluster0.pgpt2.mongodb.net/myFirstDatabase?retryWrites=true&w=majority";
            var mongoClient = new MongoClient(mongoConnectionString);
            return mongoClient.GetDatabase("game-tests");
        }
    }
}