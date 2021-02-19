using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0, diff = 0;
            int sumOfPrevious = 0, max=0;
            for (int i = 1; i <= n*2; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (i%2 == 0)
                {
                   sum += num;
                }
                diff = sum - sumOfPrevious;
                sumOfPrevious = sum;
                if ()
                {

                }
                sum = 0;
            }
            if (max)
            {
                Console.WriteLine("Yes" );
            }
            else
            {
                Console.WriteLine("No " );
            }
        }
    }
}
