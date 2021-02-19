using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b=0;
            a = int.Parse(Console.ReadLine());
            while (true)
            {
                b = a % 10;
                a =a/ 10; Console.Write(b);
                if (a<=0)
                {
                    break;
                }
            }
        }
    }
}
