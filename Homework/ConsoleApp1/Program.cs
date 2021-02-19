using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Check(int i, int k)
        {
            int num = i;
            int counter = 1;
            int sum = 0;
            while (num > 0)
            {             
                sum += num % 10;
                num /= 10;
                if (k <= sum / counter && counter>1)
                {
                    Console.WriteLine(i);
                    break;
                }
                counter++;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (n>m)
            {
                int x = n;
                n = m;
                m = x;
            }
            for (int i = n; i <= m; i++)
            {
                Check(i,k);
            }
        }
    }
}
