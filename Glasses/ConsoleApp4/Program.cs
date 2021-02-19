using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minusesL = n * 3;
            int minusesR = (n * 2) - 2;
            int between = 0;
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string('-', minusesL));
                Console.Write('*');
                Console.Write(new string('-', between));
                Console.Write('*');
                Console.WriteLine(new string('-', minusesR));
                if (row <= n - 1)
                {
                    between++;
                    minusesR--;
                }
            }
            for (int row = 0; row < n / 2; row++)
            {
                Console.Write(new string('*', minusesL));
                Console.Write('*');
                Console.Write(new string('-', between));
                Console.Write('*');
                Console.WriteLine(new string('-', minusesR));
            }
            for (int row = 0; row <= (n / 2) - 1; row++)
            {
                if (row == (n / 2) - 1)
                {
                    if (n % 2 == 0)
                    {
                        between = (n * 2) - 1;
                    }
                    else
                    {
                        between = (n * 2) - 2;
                        if (n <= 5)
                        {
                            minusesL--; minusesR--;
                        }

                    }
                    Console.Write(new string('-', minusesL));
                    Console.Write(new string('*', between));
                    Console.WriteLine(new string('-', minusesR));
                }
                else
                {
                    Console.Write(new string('-', minusesL));
                    Console.Write('*');
                    Console.Write(new string('-', between));
                    Console.Write('*');
                    Console.WriteLine(new string('-', minusesR));
                }
                if (n > 5 && row < (n / 2) - 1)
                {
                    minusesR--;
                    between += 2;
                    minusesL--;
                }
            }
        }
    }
}
