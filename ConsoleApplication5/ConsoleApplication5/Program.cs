using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, sum, k, b;
            
             k = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            do
            {
                b = int.Parse(Console.ReadLine());
                sum = b + b;
                a++;
            } while (k<=sum);
            Console.WriteLine(a);
        }
    }
}
