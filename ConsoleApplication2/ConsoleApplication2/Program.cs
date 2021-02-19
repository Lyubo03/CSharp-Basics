using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    { 
        static void Main(string[] args)
        {
            do
            {
                int n = int.Parse(Console.ReadLine());
                // if (n<0)
                //{
                //Console.WriteLine("Error");
                //}
                int i = 1; int b = 2000; 
                int result = n + i+b;
                b++; i++;
                Console.WriteLine(result);
            } while (true);
        }
    }
}
