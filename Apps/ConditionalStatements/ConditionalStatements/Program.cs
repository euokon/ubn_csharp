using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statememt

            int num1 = 34;
            if (num1 > 70)
            {
                Console.WriteLine(num1 + " is greater than 70");
            }
            else
            {
                Console.WriteLine(num1 + " is less than 70");
            }

            int num2 = 56;
            if (!(num2 < 28))
            {
                Console.WriteLine(num2 + " is greater than 28");
            }
            else
            {
                Console.WriteLine(num2 + " is less than 28");
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");

            // switch statement

            int num3 = 2;
            switch (num3)
            {
                case 1: Console.WriteLine("Value is " + num3 * 1);
                    break;
                case 2: Console.WriteLine("Value is " + num3 * 2);
                    break;
                case 3: Console.WriteLine("Value is " + num3 * 3);
                    break;
                case 4: Console.WriteLine("Value is " + num3 * 4);
                    break;
                default: Console.WriteLine("Value is " + 0);
                    break;
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");

            // for loop
            int num4 = 10;
            for (int i = 1; i < num4; i += 2)
            { 
                Console.WriteLine("The value is " + i);
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");

            // while loop
            int num5 = 5;
            int j = 0;
            while (j < num5)
            { 
                //j += 1;
                Console.WriteLine("The value is " + j);
                j += 1;
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");

            int num6 = 50;
            for (int i = 30; i < num6; i += 2)
            {
                Console.WriteLine("The value is " + i);
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");

            int num7 = 50;
            int k = 31;
            while (k < num7)
            {
                //j += 1;
                Console.WriteLine("The value is " + k);
                k += 2;
            }
        }
    }
}

