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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = a;
            if (a < b)
            {
                max = a;
                a = b;
                b = max;
            }
            while (b!=0)
            {
                int ost = a % b;
                a = b;
                b = ost;
            }
            Console.WriteLine(a);
        }
    }
}
