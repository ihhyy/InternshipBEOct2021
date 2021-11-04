﻿using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace WebApi.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getUserInfo")]
        public async Task<IActionResult> GetUserInfo()
        {
            var userName = User.Identity.Name;

            return Ok(await _userService.GetUserInfoByUserNameAsync(userName));
        }

        [HttpGet("getAllUsersByInternship")]
        public async Task<IActionResult> GetAllUsersByInternshipId([FromQuery] int id)
        {
            return Ok(await _userService.GetMentorsByInternshipId(id));            
        }
    }
}
