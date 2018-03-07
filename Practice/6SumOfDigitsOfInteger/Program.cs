using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6SumOfDigitsOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sum = 0, b;
            Console.WriteLine("Enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            while (a!=0)
            {
                sum = sum + (a % 10);
                a = a / 10;
            }
            Console.WriteLine("The sum of the digits is " +sum);
            Console.ReadLine();

        }
    }
}
