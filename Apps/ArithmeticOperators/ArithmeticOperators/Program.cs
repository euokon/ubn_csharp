using System;

namespace ArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // addition +
            // subtraction -
            // multiplication *
            // division /
            // modulus %
            // increment ++
            // decrement --

            int num1 = 10;
            int num2 = 20;
            int num3 = 5;
            double num4 = 40.8;

            double res = 0;

            res = num1 + num2;
            Console.WriteLine("Addition: " + res);

            res = num2 - num1;
            Console.WriteLine("Subtraction: " + res);

            res = num2 / num3;
            Console.WriteLine("Division: " + res);

            res = num4 * num3;
            Console.WriteLine("Multiplication: " + res);

            res = num4 % num1;
            Console.WriteLine("Modulus: " + res);

            //num1 = ++num1;
            Console.WriteLine("Increment: " + ++num1);

            //num4 = --num4;
            Console.WriteLine("Decrement: " + --num4);

            num1 += 2;
            Console.WriteLine("Increment II: " + num1);

            num4 -= 5;
            Console.WriteLine("Decrement II: " + num4);
        }
    }
}

