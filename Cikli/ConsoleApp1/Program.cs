using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = 1;
            for (int i = 1; i <= n ; i++)
            {
                b *= 2; 
                Console.WriteLine(b);
            }
        }
    }
}
