﻿using System;
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
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num<min)
                {
                    min = num;
                }
                Console.WriteLine(min);
            }
        }
    }
}
