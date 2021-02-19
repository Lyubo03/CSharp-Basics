using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = new int[4];
            int counter = 0;
            int num = int.Parse(Console.ReadLine());
            while (num !=0)
            {
                digits [counter] = num;
                counter++;
                num = int.Parse(Console.ReadLine());
            }
            counter--;
            while (counter >= 0)
            {              
                Console.Write(digits[counter] + " ");
                counter--;
            }
            Console.WriteLine();
        }
    }
}
