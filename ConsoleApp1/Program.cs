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
            Console.Write("Enter score: ");
            double points = double.Parse(Console.ReadLine());
            double bonus = 0;
            if (bonus <= 100)
            {
                bonus += 5;
            }
            if (points > 100)
            {
                bonus =  points * 0.20;
            }
            if (points > 1000)
            {
                bonus = points * 0.10;
            }
            if (points %2 == 0)
            {
                bonus += 1;
            }
            if (points%10 == 5)
            {
                bonus += 2; 
            }
            double sumpoints = points + bonus;
            Console.WriteLine("Bonus score: " + bonus);
            Console.WriteLine("Total score: " + sumpoints);
        }
    }
}
