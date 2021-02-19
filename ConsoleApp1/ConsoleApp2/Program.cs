using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void HeaderRow(int n)
        {
            for (int col = 0; col < n * 2; col++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        static void BodyRow(int n)
        {
            for (int col = 0; col < n - 2; col++)
            {
                Console.Write("-");
                for (int row = 1; row < n; row++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
        static void FooterRow(int n)
        {
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("-");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HeaderRow(n);
            BodyRow(n);
            FooterRow(n);
            Console.WriteLine();
        }
    }
}
