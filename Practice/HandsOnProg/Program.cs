using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 40, 89, 56, 88, 75, 89 };
            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] < 35)
                {
                    Console.WriteLine("Failed");
                    Console.ReadLine();
                    break;
                }


                else
                        {
                    Console.WriteLine("Pass");
                }                     

            }
            Console.ReadLine();
        }
    }
}

