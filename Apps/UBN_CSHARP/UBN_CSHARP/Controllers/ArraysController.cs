using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UBN_CSHARP.Controllers
{
    [Route("api/[controller]")]
    public class ArraysController : Controller
    {
        [HttpGet("Example")]
        public IEnumerable<string> Example()
        {
            //Array Declaration
            string[] animals;
            int[] weights;
            double[] accountBalances;

            //Initialize an Array
            animals = new string[4] { "Dog", "Fish", "Lion", "Cat" };
            weights = new int[] { 78, 56, 97, 44, 87, 98, 54 };
            accountBalances = new double[] { 500.87, 12065.77, 4563.904 };

            //Declare and Initialize an Array
            int[] staffId = new int[6];
            staffId[0] = 5678;
            staffId[1] = 78659;
            staffId[2] = 24356;
            staffId[3] = 7884659;
            staffId[4] = 948638;
            staffId[5] = 243658;

            return animals;
        }

        [HttpGet("Example1/{num}")]
        public string Example1(int num)
        {
            string[] animals = new string[4] { "Dog", "Fish", "Lion", "Cat" };
            return animals[num];
        }

        [HttpGet("Example2/{num}")]
        public int Example2(int num)
        {
            int[] weights = new int[] { 78, 56, 97, 44, 87, 98, 54 };
            return weights[num];
        }

        [HttpGet("Example3/{id}")]
        public int Example3(int id)
        {
            //Declare and Initialize an Array
            int[] staffId = new int[6];
            staffId[0] = 5678;
            staffId[1] = 78659;
            staffId[2] = 24356;
            staffId[3] = 7884659;
            staffId[4] = 948638;
            staffId[5] = 243658;

            return staffId[id];
        }

        [HttpGet("Example4")]
        public IEnumerable<int> Example4()
        {
            //Declare and Initialize an Array
            int[] staffId = new int[6];
            staffId[0] = 5678;
            staffId[1] = 78659;
            staffId[2] = 24356;
            staffId[3] = 7884659;
            staffId[4] = 948638;
            staffId[5] = 243658;

            return staffId;
        }

        [HttpGet("Example5")]
        public int Example5()
        {
            int res = 0;
            int[] weights = new int[] { 78, 56, 97, 44, 87, 98, 54 };

            //Lenght of an array
            res = weights.Length;

            return res;
        }

        [HttpGet("Example6")]
        public int Example6()
        {
            int[] weights = new int[] { 78, 56, 97, 44, 87, 98, 54 };
            int num = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                num = weights[i];
            }

            return num;
        }

        [HttpGet("Example7")]
        public IEnumerable<int> Example7()
        {
            int[] weights = new int[] { 78, 56, 97, 44, 87, 98, 54 };
            int[] newWeights = new int[7];

            for (int i = 0; i < weights.Length; i++)
            {
                newWeights[i] = weights[i] + 5;
            }

            return newWeights;
        }

        [HttpGet("Example8")]
        public int Example8()
        {
            int[] weights = new int[] { 78, 56, 99, 44, 87, 95, 54 };
            int num = 0;

            foreach (var item in weights)
            {
                if (item > 85)
                {
                    num = item;
                }
            }

            return num;
        }

        [HttpGet("Example9")]
        public int Example9()
        {
            int[] weights = new int[] { 78, 56, 99, 44, 87, 95, 54 };
            int num = 0;

            num = weights.Max();
            num = weights.Min();

            return num;
        }


    }
}

