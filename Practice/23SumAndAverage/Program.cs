using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double avg;
            int i, n, sum = 0;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Num-{0} :",i);
                n = Convert.ToInt32(Console.ReadLine());
                sum = sum + n;
            }
            avg = sum / 10.0;
            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Average is " + avg);
            Console.ReadLine();

        }
    }
}
