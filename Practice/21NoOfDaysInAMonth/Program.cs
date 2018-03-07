using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21NoOfDaysInAMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the month number");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("The month has 31 days");
                    break;
                case 2:
                    Console.WriteLine("The month has 28 days. It has 29 days if it is a leap year");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("The month has 30 days");
                    break;
                default:
                    Console.WriteLine("Enter valid month");
                    break;
            }
            Console.ReadLine();
        }
    }
}
