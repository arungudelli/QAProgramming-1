using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksUsingFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 37, 75, 51, 65, 99, 80 };          
                                
        }

        static string grade(int[] marks)
        {
            string returnValue = "";

            for (int i = 0; i < 6; i++)
            {
                if (marks[i] > 35)
                {
                    returnValue= "Pass";
                    break;
                }
                else
                {
                    returnValue= "Fail";
                    break;
                }

            }

            return returnValue;

        }
        string a = grade(marks[i]);
        Console.WriteLine(a);
           
    }
}
