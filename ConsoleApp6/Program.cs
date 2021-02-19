using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            if (num %2 ==0)
            {
                Console.WriteLine("even");
            }
            if (num %3 == 0)
            {
                Console.WriteLine("odd");
            }
        }
    }
}
