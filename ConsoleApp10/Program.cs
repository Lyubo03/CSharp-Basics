using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            mins += 15;
            if (mins >= 60)
            {  
                mins = mins - 60;
                hours++;
            }
            if (hours >= 24)
            {
                hours -= 24;
                //mins += 60;
            }   
            if (mins<10)
            {
                 Console.WriteLine(hours + ":" + "0" + mins);
            }
            else
            {
                 Console.WriteLine(hours + ":" + mins);
            }
        }
    }
}
