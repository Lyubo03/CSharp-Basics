using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a>b)
            {
                Console.Write("Greater number: " + a);
            }
            else 
            {
                Console.Write("Greater number: " + b);
            }
        }
    }
}
