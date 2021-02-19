using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, k , b, sum=0;
            k = int.Parse(Console.ReadLine());
            while (true)
            {
                b = int.Parse(Console.ReadLine());
                a++;
                sum += b;
                if (sum>=k)
                {
                    Console.WriteLine(a);
                    break;
                }
            }
        }
    }
}
