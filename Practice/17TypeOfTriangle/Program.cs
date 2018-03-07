using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17TypeOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter side1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side2");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side3");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a == b) && (b == c))
            {
                Console.WriteLine("The triangle is equilateral");
            }
            else if ((a == b) || (a == c) || (b == c))
            {
                Console.WriteLine("The triangle is isosceles");

            }
            else
            {
                Console.WriteLine("The triangle is scalene");

            }
            Console.ReadLine();
        }
    }
}
