using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9NewStringOfAlternateCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string");
            string a = Console.ReadLine();
            var res = string.Empty;
            for (var i = 0; i < a.Length; i = i + 2)
            {
                res += a[i];
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
