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
        [HttpPost]
        public IActionResult Create(CreateUserReaquest request)
        {
            if (request.Profile == Profile.CBF && request.Password != "admin123")
            {
                return Unauthorized();
            }
            var user = new User(request.Name, request.Profile);

            return Ok(user.Id);
        }
    }
}