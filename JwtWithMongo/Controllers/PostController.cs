using System.Collections.Generic;
using AutoMapper;
using JwtWithMongo.Dtos;
using JwtWithMongo.Entities;
using JwtWithMongo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtWithMongo.Controllers
{
    [Route("api/[controller]/{id}")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly UserService service;

        private readonly IMapper mapper;

        public PostController(UserService _service, IMapper _mapper)
        {
            service = _service;
            mapper = _mapper;
        }
        
        [HttpPost]
        [Authorize]
        public ActionResult<PostDTO> CreatePost(PostDTO post,string id)
        {
            service.CreatePost(mapper.Map<Post>(post), id);
            return Ok();
        }
    }
}

