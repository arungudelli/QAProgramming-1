using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26RightAngleWithNumberRepeating
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, r;
            Console.Write("Input number of rows : ");
            r = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= r; i++)
            {
                for (j = 1; j <= i; j++)
                Console.Write("{0}", i);
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
