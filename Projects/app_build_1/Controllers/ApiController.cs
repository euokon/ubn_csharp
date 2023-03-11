using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace app_build_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        // GET: api/values
        [HttpGet("Example")] 
        public IEnumerable<string> Get()
        {
            //Array Declaration
            string[] animals;
            int[] weights;
            double[] account_balances;

            //Initialize Array
            animals = new string[] {"Cat", "Crocodile", "Fish", "Eagle"};
            weights = new int[] { 10, 29, 38, 47, 56 };
            account_balances = new double[] { 987.01, 654.23 };

            //Declare and Initialize an Array
            int[] staffId = new int[6];
            staffId[0] = 0001;
            staffId[1] = 0012345;
            staffId[2] = 01234;
            staffId[3] = 1234;
            staffId[4] = 2345;
            staffId[5] = 000;
           
            return animals;
        }

        // GET api/values/5
        [HttpGet("Example/{num}")]
        public string Example(int num)
        {
            string[] animals = new string[4] { "Cat", "Crocodile", "Fish", "Eagle" };
            return animals[num];
        }

        // GET api/values/5
        [HttpGet("Example6")]
        public int Example6()
        {
            //Declare and Initialize an Array
            int[] weights = new int[] {10, 29, 38, 47, 56};
            int num = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                num = weights[i];
            }
            return num;
        }

        
        }
}
