using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (a == b)
            {
                Console.WriteLine("yes");
            }
            else if (a!=b)
            {
                Console.WriteLine("no");
            }
        }
    }
}
