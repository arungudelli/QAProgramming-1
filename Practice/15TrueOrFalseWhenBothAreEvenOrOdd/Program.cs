using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15TrueOrFalseWhenBothAreEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number");
            num2 = Convert.ToInt32(Console.ReadLine());
            if ((num1 % 2 == 0) && (num2 % 2 == 0))
            {
                Console.WriteLine("True:Both are even numbers");
            }
           
            else if ((num1 % 2 != 0) && (num2 % 2 != 0))
            {
                Console.WriteLine("True:Both are odd numbers");
            }
            else
            {
                Console.WriteLine("False: One of the number is even");
            }

            Console.ReadLine();
        }
    }
}
