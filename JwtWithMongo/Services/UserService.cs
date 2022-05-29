using System;
using JwtWithMongo.Entities;
using JwtWithMongo.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace JwtWithMongo.Services
{
	public class UserService: IUserService
	{
		private readonly IMongoCollection<User> users;

		public UserService(IConfiguration configuration)
        {
			var client = new MongoClient(configuration.GetConnectionString("HyphenDb"));

			var database = client.GetDatabase("HyphenDb");

			users = database.GetCollection<User>("Users");

		}

		public User GetUser(string id) => users.Find<User>(user => user.Id.Equals(id)).FirstOrDefault();

		public User GetUserByEmailAndPassword(string email, string password) => users.Find<User>(user => user.Email ==email && user.Password == password).FirstOrDefault();

        public User CreateUser(User user)
        {
			User validUser = GetUserByEmailAndPassword(user.Email, user.Password);

			if (validUser != null && validUser.Name != null)
			{
				return null;
			}
			users.InsertOne(user);
			return user;
		}

        public void CreatePost(Post post, string userId)
        {
			User user = GetUser(userId);
			user.Posts.Add(post);
			users.ReplaceOneAsync(x => x.Id == userId, user);

		}

		
    }
}

