using DatabaseConnection_api.domain.Services;
using DatabaseConnection_api.domain.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseConnection_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServices _services;
        public CustomerController(ICustomerServices customerServices)
        {
            _services = customerServices;
        }

        [HttpGet, Route("GetCustomer/{accountNumber}")]
        public async Task<IActionResult> GetCustomer(string accountNumber)
        {
            try
            {
                var users = await _services.FetchCustomer(accountNumber);
                // _genServ.LogRequestResponse("GetUsers: ", "GetUsers - ", JsonConvert.SerializeObject(users));
                return Ok(users);
            }
            catch (Exception ex)
            {
                // _genServ.LogRequestResponse("GetUsers Exception: ", ex.Message, ex.StackTrace);
                return NotFound();
            }
        }
    }
}
