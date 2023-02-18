using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UBN_CSHARP.Models;

namespace UBN_CSHARP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqExampleController : ControllerBase
    {
        [HttpGet("Customers")]
        public IActionResult GetCustomers()
        {
            var customers = CustomerData.Customers.Select(a => new
            {
                CustomerId = a.CustomerId,
                CustomerName = a.CustomerName,
                CustomerType = a.CustomerType,
                Gender = a.Gender,
                CustomerRelationshipDate = a.CustomerRelationshipDate,
            });

            return Ok(customers);
        }
    }
}
