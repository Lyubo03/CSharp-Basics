using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string form = Console.ReadLine();
            double area = 0;
            if (form == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            if (form == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            if (form == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                area = Math.PI*a*a;
            }
            if (form == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = (a * b)/2;
            }
            area = Math.Round(area, 3);
            Console.WriteLine(area);
        }
    }
}
