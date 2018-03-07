using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22SumOfFirstTenNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, sum = 0;
            for (j = 0; j <=10; j++)
            {
                sum = sum + j;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
