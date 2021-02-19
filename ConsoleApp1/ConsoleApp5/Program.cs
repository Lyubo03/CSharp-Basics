using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static int MaxNumber(int a, int b)
        {
            if (a < b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        static string MaxSymbol(string a, string b)
        {
            if (a.Length < b.Length)
            {
                return b;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(MaxNumber(a, b)); break;
                case "string":
                    string c = Console.ReadLine();
                    string d = Console.ReadLine();
                    Console.WriteLine(MaxSymbol(c, d)); break;
                case "char":
                    string e = Console.ReadLine();
                    string f = Console.ReadLine();
                    Console.WriteLine(MaxSymbol(e, f)); break;
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }


        }
    }
}
