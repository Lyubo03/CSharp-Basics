﻿using System;
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
            string pet = Console.ReadLine();
            switch (pet)
            {
                case "dog": Console.WriteLine("mammal"); break;
                case "crocodile": Console.WriteLine("reptile"); break;
                case "snake": Console.WriteLine("reptile"); break;
                case "tortoise": Console.WriteLine("reptile"); break;
                default: Console.WriteLine("unknown"); break;
            }

        }
    }
}