using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tirenca = (n * 2) + 1;
            int stars = n + 1;
            for (int row = 1; row <= n + 1; row++)
            {
                Console.Write(new string('.', stars));
                if (row > 1)
                {
                    Console.Write("//");
                }
                Console.Write(new string('_', tirenca));
                if (row > 1)
                {
                    Console.Write(@"\\");
                }
                Console.WriteLine(new string('.', stars));
                if (row < 2)
                {
                    tirenca = (n * 2) - 1;
                }
                else
                {
                    tirenca += 2;
                }
                stars--;
            }
            Console.Write("//");
            if (n < 4)
            {
                Console.Write(new string('_', n));
            }
            else
            {
                Console.Write(new string('_', (n * 2) - 3));
            }
            Console.Write("STOP!");
            if (n < 4)
            {
                Console.Write(new string('_', n));
            }
            else
            {
                Console.Write(new string('_', (n * 2) - 3));
            }
            Console.WriteLine(@"\\");
            tirenca = (n * 4)-1;
            stars = 0;
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string('.', stars));
                Console.Write(@"\\");
                Console.Write(new string('_', tirenca));
                Console.Write("//");
                Console.WriteLine(new string('.', stars));
                tirenca -= 2;
                stars++;
            }
        }
    }
}
