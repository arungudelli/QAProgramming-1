using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16LeapYearOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, a;
            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());
            a = year % 4;
            if (a == 0)
            {
                Console.WriteLine("The entered year is a leap year");
            }
            else
            {
                Console.WriteLine("The entered year is not a leap year");

            }
            Console.ReadLine();
        }
    }
}
