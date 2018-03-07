using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20ElectricityBill
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, unit;
            string name;
            double charge, surcharge = 0, total, overall;
                        
            Console.WriteLine("Enter customer ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.Write("No of units consumed");
            unit = Convert.ToInt32(Console.ReadLine());
            if (unit < 200)
                charge = 1.20;
            else if (unit >= 200 && unit < 400)
                charge = 1.50;
            else if (unit >= 400 && unit < 600)
                charge = 1.80;
            else
                charge = 2.00;
            total = unit * charge;
            if (total > 400) 
                surcharge = total * 15 / 100.0;
            overall = total + surcharge;
            //test
            if (overall < 100)
                overall = 100;
            Console.WriteLine("Customer ID is " + id);
            Console.WriteLine("Customer name is " + name);
            Console.WriteLine("Units consumed by customer " + unit);
            Console.WriteLine("Charges are " + charge);
            Console.WriteLine("Total Amount is " + total);
            Console.WriteLine("Surcharge amount is " + surcharge);
            Console.WriteLine("Grand Total is " + overall);
            Console.ReadLine();

        }
    }
    }
