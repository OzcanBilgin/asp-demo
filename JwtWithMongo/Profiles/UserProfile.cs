using System;
using AutoMapper;
using JwtWithMongo.Dtos;
using JwtWithMongo.Models;

namespace JwtWithMongo.Profiles
{
	public class UserProfile: Profile
	{
		public UserProfile()
        {
			CreateMap<User, UserDTO>();
			CreateMap<UserDTO, User>();
		}
	}
}

