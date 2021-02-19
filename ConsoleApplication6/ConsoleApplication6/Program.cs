using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, sum=0, k, b,;
            k = int.Parse(Console.ReadLine()); 
            
            
            do
            {    b = int.Parse(Console.ReadLine());
                 
               a++; sum = b + b;
                
            } while (k>=sum);
            Console.WriteLine(a);
        }
    }
}
