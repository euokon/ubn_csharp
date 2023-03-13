using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SimpleApi.Domain.Models;
using SimpleApi.Domain.Services;
using SimpleApi.Domain.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IGenericService _genServ;

        public UserController(IUserService userService, IGenericService genServ)
        {
            _userService = userService;
            _genServ = genServ;
        }

        [HttpPost, Route("AddUser")]
        public async Task<IActionResult> AddUser([FromBody] CreateUser request)
        {
            try
            {
                var resp = await _userService.AddUser(request);
                _genServ.LogRequestResponse("CreateUser: ", JsonConvert.SerializeObject(request), JsonConvert.SerializeObject(resp));
                if (resp)
                    return Ok();
                return BadRequest();
            }
            catch (Exception ex)
            {
                _genServ.LogRequestResponse("AddUser Exception: ", ex.Message, ex.StackTrace);
                return BadRequest();
            }
        }

        [HttpGet, Route("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var users = await _userService.GetUsers();
                _genServ.LogRequestResponse("GetUsers: ", "GetUsers - ", JsonConvert.SerializeObject(users));
                return Ok(users);
            }
            catch (Exception ex)
            {
                _genServ.LogRequestResponse("GetUsers Exception: ", ex.Message, ex.StackTrace);
                return NotFound();
            }

        }

        [HttpGet, Route("{userId}")]
        public async Task<IActionResult> GetUser(int userId)
        {
            try
            {
                var user = await _userService.GetUser(userId);
                _genServ.LogRequestResponse("GetUsers: ", "GetUsers - ", JsonConvert.SerializeObject(user));
                if(user != null)
                    return Ok(user);
                return NotFound("No Records Found for the UserId provided");
            }
            catch (Exception ex)
            {
                _genServ.LogRequestResponse("GetUsers Exception: ", ex.Message, ex.StackTrace);
                return NotFound();
            }

        }
    }
}

