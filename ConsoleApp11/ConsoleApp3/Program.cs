using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            int b;
            while (sum==1)
            {
                while (a!=0)
                {
                b = a % 10;
                sum += b * b;
                a = a / 10;
                }
                a = sum;
                sum = 0;
                  
            } Console.WriteLine("true");
            
        }
    }
}
