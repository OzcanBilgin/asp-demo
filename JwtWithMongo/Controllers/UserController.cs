using System.Collections.Generic;
using AutoMapper;
using JwtWithMongo.Dtos;
using JwtWithMongo.Entities;
using JwtWithMongo.Models;
using JwtWithMongo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtWithMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly UserService service;

        private readonly IMapper mapper;

        public UserController(UserService _service, IMapper _mapper)
        {
            service = _service;
            mapper = _mapper;
        }

        [HttpPost]
        public ActionResult<UserDTO> CreateUser(UserDTO user)
        {
            User result = service.CreateUser(mapper.Map<User>(user));
            if (result == null)
            {
                return NotFound("Invalid Email");
            }
            return Json(result);
        }
    }
}

