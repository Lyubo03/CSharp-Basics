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
            int[] digits = new int[50];
            int counter = 0;
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num != 0)
            {
                digits[counter] = num;
                counter++;
                num = int.Parse(Console.ReadLine());
            }
            while (counter >= 0)
            {
                if (digits[counter] % 2 != 0)
                {
                    sum += digits[counter];
                }
                counter--;
            }
            Console.WriteLine(sum);
        }
    }
}
