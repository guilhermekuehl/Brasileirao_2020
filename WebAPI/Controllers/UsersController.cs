using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using Domain.Users;

namespace WebAPI.Controllers.UsersController
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        public readonly UsersService _usersService;
        public UsersController()
        {
            _usersService = new UsersService();
        }
        [HttpPost]
        public IActionResult Create(CreateUserRequest request)
        {
            if (request.Profile == Profile.CBF && request.Password != "admin123")
            {
                return Unauthorized();
            }

            BadRequest("Invalid name!");

            var userId = _usersService.Create(request.Name, request.Profile);

            return Ok(userId);
        }
    }
}