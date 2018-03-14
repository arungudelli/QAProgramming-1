using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27RightAngleWithNumIncByOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, r, k = 1;
            Console.Write("Enter the height : ");
            r = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= r; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", k++);
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
