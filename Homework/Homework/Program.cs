using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Check(int i)
        {
            int num = i;
            while (num > 0)
            {
                int firstCheck = num % 10;
                num /= 10;
                int secondCheck = num % 10;
                if (firstCheck == secondCheck)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            if (k > l)
            {
                int x = k;
                k = l;
                l = x;
            }
            for (int i = k; i <= l; i++)
            {
                Check(i);
            }
        }
    }
}
