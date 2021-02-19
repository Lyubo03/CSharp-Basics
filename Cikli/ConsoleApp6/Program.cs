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
            int n = int.Parse(Console.ReadLine());
            for (int col = 1; col <= n; col++)
            {
                for (int space = n-1; space >=col; space--)
                {
                    Console.Write(" ");
                }
                for (int row = 1; row <= col; row++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int col = 1; col <= n; col++)
            {
                for (int space = 1; space <= col; space++)
                {
                    Console.Write(" ");
                }
                for (int row = n; row >col; row--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
