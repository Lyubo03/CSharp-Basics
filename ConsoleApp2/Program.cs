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
            double s1 = double.Parse(Console.ReadLine());
            double s2 = double.Parse(Console.ReadLine());
            double s3 = double.Parse(Console.ReadLine());
            double sec = s1 + s2 + s3;
            int min = 0;
            if (sec <=59)
            {
                if (sec<10)
                {
                    Console.WriteLine(min + ":" + "0" + sec);
                }
                else
                {
                    Console.WriteLine(min + ":"  + sec);
                }

            }
            else if (sec<=119)
            {
                min++;
                sec = sec - 60;
                if (sec<10)
                {
                    Console.WriteLine(min + ":" + "0" + sec);
                }
                else
                {
                    Console.WriteLine(min + ":" + sec);
                }
            }
            else if (sec<=179)
            {
                min += 2;
                sec = sec - 120;
                if (sec < 10)
                {
                    Console.WriteLine(min + ":" + "0" + sec);
                }
                else
                {
                    Console.WriteLine(min + ":" + sec);
                }
            }
        }
    }
}
