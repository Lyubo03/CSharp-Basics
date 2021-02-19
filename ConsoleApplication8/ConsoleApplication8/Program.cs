using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, sum=0;
            int a = int.Parse(Console.ReadLine());
            while (true)
            {
                b = a % 10;
                sum += b;
                a = a / 10;
                if (a<=0)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
