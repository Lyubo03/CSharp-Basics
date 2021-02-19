using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                for (int i = 1; i < n; i++)
                {
                    if (row % 2 == 0 && row ==1)
                    {
                        Console.WriteLine("**");
                    }
                    else if (row % 3 == 0 && row ==1)
                    {
                        Console.WriteLine("*");
                    }
                }
            }
        }
    }
}
