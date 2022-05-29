using System;
using JwtWithMongo.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JwtWithMongo.Entities
{
	public class Post
	{
		[BsonId]
		[BsonElement("_id")]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }

		public string Message { get; set; }

	}
}

