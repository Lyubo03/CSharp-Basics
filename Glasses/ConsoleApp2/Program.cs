using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars= n;
            int inside = n * 3;
            Console.Write(new string('.', stars));
            Console.Write(new string('*', inside));
            Console.WriteLine(new string('.', stars));
            inside -= 2;
            for (int row = 0; row < n; row++)
            {

                Console.Write(new string('.', stars));
                Console.Write('*');
                Console.Write(new string('.', inside));
                Console.Write('*');
                Console.WriteLine(new string('.', stars));
                stars--;
                inside += 2;
            }
            Console.WriteLine(new string('*', n * 5));
            stars = 1;
            if (n % 2 == 0)
            {
                inside = (n * 5);
            }
            else
            {
                inside = (n * 5);
            }
            for (int row = 0; row < n * 2; row++)
            {
                if (row == 0)
                {
                    inside -= 4;
                }
                Console.Write(new string('.', stars));
                Console.Write('*');
                Console.Write(new string('.', inside));
                Console.Write('*');
                Console.WriteLine(new string('.', stars));
                stars++;
                inside -= 2;
            }
            Console.Write(new string('.', (n * 2) + 1));
            Console.Write(new string('*', n - 2));
            Console.WriteLine(new string('.', (n * 2) + 1));
        }
    }
}
