using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxpear = 0;
            int minpear = 0;
            int max = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            maxpear = min + max;
            for (int i = 4; i <= (n * 2); i++)
            {
                max = int.Parse(Console.ReadLine());
                min = int.Parse(Console.ReadLine());
                minpear = max + min;
                if (minpear > maxpear)
                {
                    maxpear = minpear;
                }   

            }
            Console.WriteLine(maxpear.ToString() + " " + minpear);
        }
    }
}
