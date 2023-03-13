using DatabaseConnection_api.domain.Models;
using DatabaseConnection_api.domain.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseConnection_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService= userService;
        }

        [HttpPost, Route("AddUser")]
        public async Task<IActionResult> AddUser([FromBody] CreateUser request)
        {
            try
            {
                var resp = await _userService.AddUser(request);

                if(resp)
                    return Ok();
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet, Route("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var users = await _userService.GetUsers();
                // _genServ.LogRequestResponse("GetUsers: ", "GetUsers - ", JsonConvert.SerializeObject(users));
                return Ok(users);
            }
            catch (Exception ex)
            {
                // _genServ.LogRequestResponse("GetUsers Exception: ", ex.Message, ex.StackTrace);
                return NotFound();
            }
        }
        [HttpGet, Route("{userId}")]
        public async Task<IActionResult> GetUser(int userId)
        {
            try
            {
                var user = await _userService.GetUser(userId);
                //_genServ.LogRequestResponse("GetUsers: ", "GetUsers - ", JsonConvert.SerializeObject(user));
                if (user != null)
                    return Ok(user);
                return NotFound("No Records Found for the UserId provided");
            }
            catch (Exception ex)
            {
                //_genServ.LogRequestResponse("GetUsers Exception: ", ex.Message, ex.StackTrace);
                return NotFound();
            }
        }
    }
}
