using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quant = double.Parse(Console.ReadLine());
            double cost = 1;
            if (city == "Sofia")
            {
                if (product == "coffe") { cost = 0.50; }
                if (product == "water") { cost = 0.80; }
                if (product == "beer") { cost = 1.20; }
                if (product == "sweets") { cost = 1.45; }
                if (product == "peanuts") { cost = 1.60; }
            }
            if (city == "Varna")
            {
                if (product == "coffe") { cost = 0.45; }
                if (product == "water") { cost = 0.70; }
                if (product == "beer") { cost = 1.10; }
                if (product == "sweets") { cost = 1.35; }
                if (product == "peanuts") { cost = 1.55; }
            }
            if (city == "Plovdiv")
            {
                if (product == "coffe") { cost = 0.40; }
                if (product == "water") { cost = 0.70; }
                if (product == "beer") { cost = 1.15; }
                if (product == "sweets") { cost = 1.30; }
                if (product == "peanuts") { cost = 1.50; }
            }
            Console.WriteLine(cost*quant);
        }
    }
}
