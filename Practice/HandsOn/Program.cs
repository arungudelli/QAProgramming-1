using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1>1 && num1<=100)
           
            else if (num1 < 35)
            {
                Console.WriteLine("The student is Pass");
            
            }
            else
            {
                Console.WriteLine("The student failed");
            }
        }
    }
}
