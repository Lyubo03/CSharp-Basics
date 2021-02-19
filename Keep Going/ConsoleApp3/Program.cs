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
            int[] mass = new int[10];
            int[] blqk = new int[10];
            int num = int.Parse(Console.ReadLine());
            int counter = 0;
            while (num != 0)
            {
                mass[counter] = num;
                counter++;
                num = int.Parse(Console.ReadLine());
            }
            counter--;
            int blqkCount = 0;
            while (counter>=0)
            {
                blqk[blqkCount] = mass[counter];
                
                Console.WriteLine(blqk[blqkCount]);
                blqkCount++;
                counter--;                
            }
        }
    }
}
