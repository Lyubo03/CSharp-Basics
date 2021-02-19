using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static bool IsHappy(int a)
        {
            int sum = 0;
            int b;
            while (sum == 1)
            {
                while (a != 0)
                {
                    b = a % 10;
                    sum += b * b;
                    a = a / 10;
                }
                a = sum;
                sum = 0;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            Console.WriteLine(IsHappy(digit));
        }
    }
}
