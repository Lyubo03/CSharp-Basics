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
            int sum = 1;
            for (int i = 0; i < n; i++)
            {
                 sum *= int.Parse(Console.ReadLine());

            }
            Console.WriteLine(sum);
        }
    }
}
