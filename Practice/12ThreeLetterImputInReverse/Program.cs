using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ThreeLetterImputInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b, c;
            Console.WriteLine("Enter first letter");
            a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter second letter");
            b = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter third letter");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0} {1} {2}", c, a, b);
            Console.ReadLine(); 
        }
    }
}
