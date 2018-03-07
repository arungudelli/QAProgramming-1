using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SumOfAllElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            var sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("The sum of all integers in an array is " + sum);
            Console.ReadLine();
        }
    }
}
