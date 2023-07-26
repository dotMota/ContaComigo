using ContaComigoAPI.Models;
using ContaComigoAPI.Services;
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
        public IActionResult CreateUser([FromBody] User user)
        {
            var createdUser = _userService.CreateUser(user);
            return Ok(createdUser);
        }

        [HttpDelete("DeleteUserByUserId")]
        public IActionResult DeleteUser(int userId)
        {
            try
            {
                _userService.RemoveUser(userId);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("GetUserByUserId")]
        public IActionResult GetUserById(int userId)
        {
            try
            {
                var user = _userService.GetUserById(userId);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut("UpdateUserByUserId")]
        public IActionResult UpdateUser(int userId, [FromBody] User user)
        {
            try
            {
                // Verifica se o ID informado corresponde ao ID no corpo da requisição
                if (userId != user.IdUser)
                {
                    return BadRequest("ID mismatch between route and request body.");
                }

                var updatedUser = _userService.UpdateUser(user);
                return Ok(updatedUser);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
