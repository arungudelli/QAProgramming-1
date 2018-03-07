using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8LargestAndLowestOfThreeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first number");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("The highest number is " + a);
                    Console.WriteLine("The lowest number is " + c);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The highest number is " + a);
                    Console.WriteLine("The lowest number is " + b);
                    Console.ReadLine();
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("The highest number is " + b);
                    Console.WriteLine("The lowest number is " + c);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The highest number is " + b);
                    Console.WriteLine("The lowest number is " + a);
                    Console.ReadLine();
                }
            }
            else if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine("The highest number is " + c);
                    Console.WriteLine("The lowest number is " + b);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The highest number is " + c);
                    Console.WriteLine("The lowest number is " + a);
                    Console.ReadLine();
                }
            }
        }
    }
}
     
