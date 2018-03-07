using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18TriangleCanBeFormedOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter angle one");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter angle two");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter angle three");
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b + c == 180)
            {
                Console.WriteLine("The triangle can be formed");
            }
            else
            {
                Console.WriteLine("Oops! This is not a valid traingle");
            }
            Console.ReadLine();
        }
    }
}
