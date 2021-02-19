using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n - 2; row++)
            {
                if (row % 2 == 0)
                {
                    Console.Write(new string ('-', n-2));
                }
                else
                {
                   Console.Write(new string('*', n-2)); 
                }
                Console.Write(@"\ ");
                Console.Write('/');
                if (row % 2 == 0)
                {
                   Console.Write(new string('-', n - 2)); 
                }
                else
                {
                    Console.Write(new string('*', n - 2));
                }
                Console.WriteLine();
            }
            Console.Write(new string(' ',n-1));
            Console.WriteLine('@');
            for (int row = 1; row <= n - 2; row++)
            {
                if (row % 2 == 0)
                {
                    Console.Write(new string('-', n - 2));
                }
                else
                {
                    Console.Write(new string('*', n - 2));
                }
                Console.Write("/ ");
                Console.Write('\\');
                if (row % 2 == 0)
                {
                    Console.Write(new string('-', n - 2));
                }
                else
                {
                    Console.Write(new string('*', n - 2));
                }
                Console.WriteLine();
            }
        }
    }
}
