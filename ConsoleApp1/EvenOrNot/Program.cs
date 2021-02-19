using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrNot
{
    class Program
    {
        static int SumOfEvenDigits(int a)
        {
            int sumOfEvens = 0;
            int b;
            while (a != 0)
            {
                b = a % 10;
                if (b % 2 == 0)
                {
                    sumOfEvens += a;
                }
                a = a / 10;
            }
            return sumOfEvens;
        }
        static int SumOfOddsDigits(int a)
        {
            int sumOfOdds = 0;
            int b;
            while (a != 0)
            {
                b = a % 10;
                if (b % 3 == 0)
                {
                    sumOfOdds += b;
                }
                a = a / 10;
            }
            return sumOfOdds;
        }
        static int GetMultipleOfEvensAndOdds(int a)
        {
            return SumOfOddsDigits(a) * SumOfEvenDigits(a);
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(a));
            Console.WriteLine(SumOfEvenDigits(a));
        }
    }
}
