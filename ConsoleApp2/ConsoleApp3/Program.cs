using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxi = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (maxi<num)
                {
                    maxi = num;
                }
            }
            Console.WriteLine(maxi);
        }
    }
}
