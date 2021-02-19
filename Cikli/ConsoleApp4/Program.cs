using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in the range[1...100]: ");
            int n = int.Parse(Console.ReadLine());
            while (true)
            {
                if (n < 1 || n > 100)
                {
                    Console.WriteLine("Invalid number! ");
                    Console.WriteLine("Enter a number in the range[1...100]: ");
                    n = int.Parse(Console.ReadLine());
                }
                if (n >= 1 && n <= 100)
                {
                    Console.WriteLine("The number is: " + n);
                    break;
                }

            }
        }
    }
}
