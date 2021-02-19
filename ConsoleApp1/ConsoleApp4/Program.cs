using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static double NumberPower(double a, int b) 
        {
            double result = 1;
            for (int i = 1; i <= b; i++)
            {
                result *=a;
            }
            return result;
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberPower(a,b));
        }
    }
}
