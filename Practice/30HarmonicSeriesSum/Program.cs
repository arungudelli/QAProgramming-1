using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30HarmonicSeriesSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            double s = 0.0;
            Console.Write("Enter the num of terms");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.Write(s);
            Console.ReadLine();

        }
    }
}
