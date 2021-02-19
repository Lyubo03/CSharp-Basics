using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write('/');
            Console.Write(new string('^', n / 2));
            Console.Write('\\');
            Console.Write(new string ('_', (n/2)-2));
            Console.Write('/');
            Console.Write(new string('^', n / 2));
            Console.WriteLine('\\');
            for (int row = 1; row <= n-2; row++)
            {
                Console.Write('|');
                for (int space = 1; space <= (n*2)-4; space++)
                {
                        Console.Write(' ');
                }
                Console.WriteLine('|');
            }
            Console.Write('\\');
            Console.Write(new string('_', n / 2));
            Console.Write('/');
            Console.Write(new string('-' , (n / 2) - 2));
            Console.Write('\\');
            Console.Write(new string('_', n / 2));
            Console.Write('/');
        }
    }
}
