using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void WhatNumber(int a)
        {
            if (a < 0)
            {
                Console.WriteLine("The number is " + a + " negative.");
            }
            else if (a == 0)
            {
                Console.WriteLine("The number " + a + " is zero.");
            }
            else
            {
                Console.WriteLine("The number is " + a + " postitive.");
            }

        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            WhatNumber(a);
        }
    }
}
