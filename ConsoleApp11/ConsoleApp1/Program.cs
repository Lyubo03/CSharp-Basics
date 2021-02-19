using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    
    class Program
    {
        static bool IsHappy(int a)
    {
            int sum = 0;
            int b;
        while (true)
        {
            b = a % 10;
            sum += b * b;
            a= a / 10;
            if (a==0)
            {
                a=sum;
            }
            if (sum == 1) 
            { 
               return true; 
            }
        }
    }
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(IsHappy(b));
        }
    }
}
