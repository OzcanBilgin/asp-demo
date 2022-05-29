using System;
using System.ComponentModel.DataAnnotations;

namespace JwtWithMongo.Models
{
	public class UserLogin
	{
		[Required]
		[EmailAddress(ErrorMessage = "Invalid Email")]
		public string Email { get; set; }

		[Required]
		public string Password { get; set; }
	}
}

