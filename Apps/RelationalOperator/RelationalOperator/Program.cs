using System;

namespace RelationalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // == checks equality or exactness
            // != not equal to
            // > greater than
            // >= greater than or equal to
            // < less than
            // <= less than or equal to

            int num1 = 12;
            int num2 = 24;
            int num3 = 4;
            double num4 = 15.69;

            bool res;

            // equality
            res = num1 == num2;
            Console.WriteLine("num1 == num2 is " + res);

            // not equal to
            res = num1 != num2;
            Console.WriteLine("num1 != num2 is " + res);

            // greater than
            res = num2 > num3;
            Console.WriteLine("num2 > num3 is " + res);

            // less than
            res = num2 < num3;
            Console.WriteLine("num2 < num3 is " + res);

            // greater than or equal to
            res = num4 >= num3;
            Console.WriteLine("num4 >= num3 is " + res);

            // less than or equal to
            res = num4 <= num3;
            Console.WriteLine("num4 <= num3 is " + res);
        }
    }
}

