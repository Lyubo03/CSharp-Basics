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
            for (int row = 1; row < n; row++)
            {
                for (int space = n; space >= row; space--)
                {
                    Console.Write(" ");
                }
                for (int stars = 1; stars <= row; stars++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int row = 1; row <= n; row++)
            {
                for (int spaces = 1; spaces <= row; spaces++)
                {
                    Console.Write(" ");
                }
                for (int zvezdev = n; zvezdev >= row; zvezdev--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
