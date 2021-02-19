using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
           // Boolean inRange = (num >= 100 && num <= 200) || num == 0;
            //if ( !inRange) { Console.WriteLine("invalid"); }
            if (num<=200 && num>=100 || num==0)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
