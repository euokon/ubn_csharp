using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 5;
            double num4 = 40.8;
            bool pes;

            double res = 0;
            res = num1 + num2;
            Console.WriteLine("Addition: " + res);
            res = num2 - num1;
            Console.WriteLine("Substraction: " + res);

            res = num2 / num3;
            Console.WriteLine("Division: " + res);

            res = num4 * num3;
            Console.WriteLine("Multiplication: " + res);

            res = num4 % num1;
            Console.WriteLine("Modulus " + res);
            num1 = num1++;
            Console.WriteLine("Increment: " + num1);
            //equality
            pes = num1 == num2;
            Console.WriteLine("num1== num2 is'" + pes);
            pes = num2 > num3;
            Console.WriteLine("num2 > num3 IS " + pes);
            //less than
            pes = num2 < num3;
            Console.WriteLine("num2<num3 is " + pes);
            //If statement;

            int nump = 34;
            if (nump > 70)
            { Console.WriteLine(nump + "is greater than 70");
            }
            else
            { Console.WriteLine(num1 + "is less than 70");
            }
            // Switch

            int bubu = 2;
            switch (bubu)
            {
                case 1: Console.WriteLine("Value is " + bubu);
                    break;
                case 2: Console.WriteLine("Value is " + 2);
                    break; 
                default:
                    Console.WriteLine("Value is " + 0);
                    break; }
                    // Foor loop

                    int numbu = 10;
            for (int i = 0; i < numbu; i++)
            {
                Console.WriteLine("print the numbers" + i);

            }

            // while loop 
            int numpa = 5;
            int j = 0;
            while (j < numpa)
            { Console.WriteLine("The Value is " + j);
                j += 1;
            }

            //CLASS-Work
            int even_num = 30;
            for (even_num = 30; even_num <= 50; even_num+=2)
            {
                Console.WriteLine("print the numbers" + even_num);
            }


            int num7 = 50;
            int k = 31;
            while(k <= num7)
            {
                Console.WriteLine("The Value is " + k);
                k += 2;
            }



        }
    }
}
