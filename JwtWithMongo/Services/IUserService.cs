using JwtWithMongo.Entities;
using JwtWithMongo.Models;

namespace JwtWithMongo.Services
{
	public interface IUserService
	{
		User GetUser(string id);

		User GetUserByEmailAndPassword(string email, string password);

		User CreateUser(User user);

		void CreatePost(Post post, string userId);

	}
}

