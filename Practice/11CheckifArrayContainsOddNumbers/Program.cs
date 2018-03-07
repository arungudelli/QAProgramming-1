using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11CheckifArrayContainsOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 7, 8, 6, };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    Console.WriteLine("Yes, the array contains odd number and the number is " + a[i]);
                    Console.ReadLine();
                }

            }
        }
    }
}
