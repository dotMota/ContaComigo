using ContaComigoAPI.Interfaces;
using ContaComigoAPI.Models;
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
            var createdUser = _userService.CreateUser(user);
            return Ok(createdUser);
        }
    }
}
