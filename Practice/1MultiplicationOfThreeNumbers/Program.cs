using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1MultiplicationOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, res;
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            num3 = Convert.ToInt32(Console.ReadLine());
            res = num1 * num2 * num3;
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
