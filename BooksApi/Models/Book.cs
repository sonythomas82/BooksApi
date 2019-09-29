using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Models
{
    public class Book
    {
        [BsonId] // Primary to the Object
        [BsonRepresentation(BsonType.ObjectId)] //Allows to pass ObjectId as string
        public string Id { get; set; }

        [BsonElement("Name")] //Representing property name in DB
        [JsonProperty("Name")]
        public string BookName { get; set; }

        public decimal Price { get; set; }
        public string Category { get; set; }

        public string Author { get; set; }
    }
}
