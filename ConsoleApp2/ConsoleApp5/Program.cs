using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rightsum = 0;
            int leftnum = 0;
            for (int i = 0; i < (n*2); i++)
            {
               int num= int.Parse(Console.ReadLine());
                if (i<n)
                {
                    leftnum += num;
                }
                else
                {
                    rightsum += num;
                }
            }
            if (leftnum == rightsum)
            {
                Console.WriteLine("Yes, sum is = " + leftnum);
            }
            else if (leftnum != rightsum)
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftnum-rightsum));
            }
        }
    }
}
