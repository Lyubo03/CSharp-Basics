using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
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
                if (x1> x)
                {
                    Console.WriteLine("Inside");
                    if (x2 < x)
                    {
                        Console.WriteLine("Inside");

                        if (y1 < y)
                        {
                            Console.WriteLine("Inside");
                            if (y2 > y)
                            {
                                Console.WriteLine("Inside");
                                if (x == x1)
                                {
                                    Console.WriteLine("Border");
                                    if (x== x2)
                                    {
                                        Console.WriteLine("Border");
                                        if (y1 ==y)
                                        {
                                            Console.WriteLine("Border");
                                            if (y2==y)
                                            {
                                                Console.WriteLine("Border");
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
                   
                }
                
            }
        }
    }
}
