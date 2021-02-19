using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftsum = 0;
            int rightsum = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    leftsum += num;
                }
                else 
                {   
                    rightsum += num;
                }
            }
            if (leftsum == rightsum)
            {
                Console.Write("Yes ");
                Console.WriteLine("Sum = " + leftsum);
            }
            else if (leftsum != rightsum)
            {
                Console.Write("No ");
                Console.WriteLine("Diff = " + Math.Abs(leftsum - rightsum));
            }
        }
    }
}
