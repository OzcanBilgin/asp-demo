using System;
using JwtWithMongo.Models;

namespace JwtWithMongo.Dtos
{
	public class UserLoginResponseDTO
	{
		public string AccessToken { get; set; }

		public User CurrentUser { get; set; }

	}
}

