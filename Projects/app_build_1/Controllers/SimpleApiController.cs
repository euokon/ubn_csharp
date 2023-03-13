using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace app_build_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleApiController : ControllerBase
    {
        [HttpGet("")]
        public string GetName()
        {
            string name = "Kindly supply a parameter";
            return name;
        }

       
        [HttpGet("{queryParam}")]
        public string GetResponse(string queryParam)
        {
            string name = "";
            if(queryParam == "name")
            {
                name = "My name is Victor!";
            }
            else if(queryParam== "job")
            {
                name = "I am a Data Analyst";
            }
            else
            {
                name = "Provide a valid name";
            }
            return name;
        }

        private string ValidateInput() 
        {
            return "Provide a valid input";
        }

        [HttpGet("additional/{num1}/{num2}")]
        public double AddNumbers(int num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        [HttpGet("subtraction/{num1}/{num2}")]
        public double SubtractNumbers(int num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }

        [HttpGet("multiplication/{num1}/{num2}")]
        public double MultiplyNumbers(int num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        [HttpGet("divition/{num1}/{num2}")]
        public double DivideNumbers(int num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
    }
}
