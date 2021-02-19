using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double roll = double.Parse(Console.ReadLine());
            double colum = double.Parse(Console.ReadLine());
            double area = roll*colum;
            switch (type)
            {
                case "Premiere": Console.WriteLine(Math.Round(area*12.00).ToString("0.00") + " leva"); break;
                case "Normal": Console.WriteLine(Math.Round(area*7.50).ToString("0.00") + " leva"); break;
                case "Discount": Console.WriteLine((area*5.00).ToString("0.00") + " leva"); break;
                default:Console.WriteLine("Error"); break;       
            }

        }
    }
}
