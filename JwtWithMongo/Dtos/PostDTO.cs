using System;
using System.ComponentModel.DataAnnotations;
using JwtWithMongo.Models;

namespace JwtWithMongo.Dtos
{
	public class PostDTO
	{
		[Key]
		public string Id { get; set; }

		[Required]
		public string Message { get; set; }
	}
}

