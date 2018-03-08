using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOddNaturalNumbersAndTheirSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum = 0;
            Console.WriteLine("Enter the number of terms");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} ", 2 * i - 1);
                sum =  sum + (2 * i - 1);
            }
            Console.WriteLine("Sum is " + sum);
            Console.ReadLine();
        }
    }
}
