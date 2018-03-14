using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28PyramidWithNumIncByOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int space, height, i, j, k, t=1;
            Console.WriteLine("Enter the height: ");
            height = Convert.ToInt32(Console.ReadLine());
            space = height - 1;
            for (i = 0; i < height; i++)
            {
                for (j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                for(k=0;k<= i;k++)
                Console.Write("{0} ", t++);
                Console.WriteLine();

                space--;
            }
            Console.ReadLine();
    }
}}
