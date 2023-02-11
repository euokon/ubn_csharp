using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UBN_CSHARP.Controllers
{
    [Route("api/[controller]")]
    public class SimpleApiController : Controller
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
                name = "My name is Emmanuel!";
            }
            else if(queryParam == "job")
            {
                name = "I am a Software Developer!";
            }
            else
            {
                //name = "Provide a valid input";
                name = ValidateInput();
            }
            return name;
        }

        private string ValidateInput()
        {
            return "Provide a valid input";
        }

        [HttpGet("addition/{num1}/{num2}")]
        public double AddNumbers(int num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        [HttpGet("addition/{num1}/{num2}")]
        public double AddNumbers(int num1, int num2)
        {
            double result = num1 + num2;
            return result;
        }

        [HttpGet("addition/{num1}/{num2}")]
        public double AddNumbers(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        [HttpGet("addition/{num1}/{num2}")]
        public double AddNumbers(int num1, double num2, int num3)
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

        [HttpGet("division/{num1}/{num2}")]
        public double DivideNumbers(int num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }

        [HttpGet("multiplication/{num1}/{num2}")]
        public double MultiplyNumbers(int num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
    }
}

