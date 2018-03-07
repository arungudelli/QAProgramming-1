using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char operation;
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operator");
            operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (operation == '+')
                Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            else if (operation == '-')
                Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            else if ((operation == 'x') || (operation == '*'))
                Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            if ((operation == '/') && (num2 != 0))
            {
                Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            }
            else
            {
                Console.WriteLine("Not a valid number for division please enter second number other than zero");
            }
            Console.ReadLine();

        }

    }
    }


