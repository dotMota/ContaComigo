using ContaComigoAPI.Models;
using ContaComigoAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContaComigoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateUser([FromBody] UserModel user)
        {
            var createdUser = _userService.CreateUserAsync(user);
            return Ok(createdUser);
        }
    }
}
