using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using JwtWithMongo.Dtos;

namespace JwtWithMongo.Models
{
	public class UserDTO
	{
		[Key]
		public string Id { get; set; }
		
		[Required]
		public string Name { get; set; }

		[Required]
		public string Surname { get; set; }

		[Required]
		public string UserName { get; set; }

		[Required]
		[EmailAddress(ErrorMessage = "Invalid Email")]
		public string Email { get; set; }

		[Required]
		[MinLength(4)]
		[MaxLength(15)]
		public string Password { get; set; }

		public ICollection<PostDTO> Posts { get; set; }
	}
}

