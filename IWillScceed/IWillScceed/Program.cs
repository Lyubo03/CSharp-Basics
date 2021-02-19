using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWillScceed
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= 2; row++)
            {
                for (int nRow = 1; nRow <= n * 2; nRow++)
                {
                    Console.Write("*");
                }
                for (int space = 1; space <= n; space++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
            for (int col = 1; col <= n - 2; col++)
            {
                Console.Write("*");
                for (int churtichki = 1; churtichki <= (n * 2) - 2; churtichki++)
                {
                    Console.Write("/");
                }
                Console.Write("*");
                if (col == 1)
                {
                    for (int lamka = 1; lamka <= n; lamka++)
                    {
                        Console.Write("/");
                    }
                }
                if (col > 1)
                {
                    for (int space = 1; space <= n; space++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                for (int churtichki = 1; churtichki <= (n * 2) - 2; churtichki++)
                {
                    Console.Write("/");
                }
                Console.WriteLine("*");

            }
            for (int neshto = 1; neshto <= 2; neshto++)
            {
                for (int i = 1; i <= n * 2; i++)
                {
                    Console.Write("*");
                }
                for (int space = 1; space <= n; space++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}