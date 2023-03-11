using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {     enum weekDays {Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
        
        static void Main(string[] args)
        {
            int num = 15; //integer data type
            double decNumber = 12.78;
            bool status = true;
            string myName = "Abisolababy";
           
            double dNum = 59.432;
            bool isActive = true;
            string myName = "Emmanuel";
            myName +="Sule";
            string lesson =" Console# Programming";

            Console.WriteLine(num);
            Console.WriteLine(decNumber);
            Console.WriteLine(status);
            Console.WriteLine(myName);
            Console.WriteLine(weekDays.Saturday);
            Console.WriteLine(isActive);
            Console.WriteLine(dNum);
            Console.WriteLine("My name is " + myName);
            Console.WriteLine("I am learning, Csharp");
            Console.ReadKey();
        }
    }
}
