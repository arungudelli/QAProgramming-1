﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = Convert.ToInt32(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine("The first number after swapping is " +a);
            Console.WriteLine("The second number after swapping is " +b);
            Console.ReadLine();
        }
    }
}
