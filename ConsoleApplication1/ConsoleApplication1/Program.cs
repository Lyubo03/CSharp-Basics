using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOON
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int c = a / 1000;
            int b = a % 10;
            int x = (a/10) % 10;
            int y = (a/100); y = y % 10;
            int result1 = c + b;
            int result2 = x + y;
            if ( result1 == result2)
            {
                Console.WriteLine("YES");  
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
