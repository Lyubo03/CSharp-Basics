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
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x1<x2 && y1<y2)
            {
                if (x1<=x)
                {
                    if (x2>=x)
                    {
                        if (y>=y1)
                        {

                            if (y<=y2)
                            {
                                Console.WriteLine("inside");
                            }
                            else
                            {
                                Console.WriteLine("outside");
                            }
                        }
                        else
                        {
                            Console.WriteLine("outside");
                        }
                    }
                    else
                    {
                        Console.WriteLine("outside");
                    }
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
            else
                        {
                            Console.WriteLine("outside");
                        }
        }
    }
}
