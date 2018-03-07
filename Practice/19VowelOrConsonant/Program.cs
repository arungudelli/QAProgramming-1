using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19VowelOrConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            char alpha;
            Console.WriteLine("Enter a character");
            alpha = Convert.ToChar(Console.ReadLine());
            switch(alpha)
            {
                case 'a':
                    Console.WriteLine("The alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("The alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("The entered alphabet is consonant");
                    break;
            }
            Console.ReadLine();
        }
    }
}
