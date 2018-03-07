using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4SumOfTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine(3 * (a * b));
            }
            else
            {
                Console.WriteLine(a * b);
            }
            Console.ReadLine();

        }
    }
}
