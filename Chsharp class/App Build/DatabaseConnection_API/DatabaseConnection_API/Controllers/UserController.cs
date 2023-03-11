using DatabaseConnection_API.domain.Models;
using DatabaseConnection_API.domain.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseConnection_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost, Route("AddUser")]
        public async Task<IActionResult> AddUser([FromBody] CreateUser request)
        {
            try
            {
                var resp = await _userService.AddUser(request);
                if (resp)
                    return Ok();
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPost, Route("activate-user")]
        public async Task<IActionResult> ActivateUser([FromBody] UserStatus request)
        {
            try
            {
                var resp = await _userService.ActivateUser(request.Id);
                if (resp)
                    return Ok();
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPost, Route("deactivate-user")]
        public async Task<IActionResult> DeactivateUser([FromBody] UserStatus request)
        {
            try
            {
                var resp = await _userService.DeactivateUser(request.Id);
                if (resp)
                    return Ok();
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
