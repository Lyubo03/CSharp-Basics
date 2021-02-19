using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            double points = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (points<=100)
            {
                bonus = bonus + 5 ;
            }
            if (points > 100)
            {
                bonus += points * 0.2;
            }
            if(points > 1000)
            {
                bonus += points * 0.1;
            }
            if (points%2==0)
            {
                bonus += 1;
            }
            if (points%10 == 5)
            {
                bonus += 2;
            }
                Console.WriteLine(points + " " + bonus + " result "+(points + bonus));
        }
    }
}
