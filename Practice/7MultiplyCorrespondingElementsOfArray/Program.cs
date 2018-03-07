using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7MultiplyCorrespondingElementsOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, -5, 4 };
            int[] b = { 1, 4, -5, -2 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] * b[i]);
                Console.ReadLine();
            }
        }
    }
}
