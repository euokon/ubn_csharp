using System;

namespace DataTypes
{
    class Program
    {
        enum weekDays { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        static void Main(string[] args)
        {
            int num = 15; // interger data type
            double decNumber = 12.78; // double data type, can be used for numbers with decimal precision or money
            bool status = true;
            string myName = "Emmanuel";

            Console.WriteLine(num);
            Console.WriteLine(decNumber);
            Console.WriteLine(status);
            Console.WriteLine(myName);
            Console.WriteLine(weekDays.Saturday);
        }
    }
}

