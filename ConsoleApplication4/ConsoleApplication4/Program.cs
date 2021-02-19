using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int k , sum=0 ,a=0,b;
            k = int.Parse(Console.ReadLine());
            do
            {
                b = int.Parse(Console.ReadLine());
                sum = b * b;
                a++;
            } while (sum <=k); Console.WriteLine(a);
        }
    }
}
