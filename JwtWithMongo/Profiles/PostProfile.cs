using System;
using AutoMapper;
using JwtWithMongo.Dtos;
using JwtWithMongo.Entities;

namespace JwtWithMongo.Profiles
{
	public class PostProfile : Profile
	{
		public PostProfile()
		{
			CreateMap<Post, PostDTO >();
			CreateMap<PostDTO, Post>();
		}
	}
}

