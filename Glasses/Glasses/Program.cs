using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int starsFR = n * 2;
            Console.Write(new string('*', starsFR));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', starsFR));
            for (int col = 0; col < n - 2; col++)
            {
                Console.Write('*');
                for (int row = 2; row < (n) * 2; row++)
                {
                    Console.Write(@"\");
                }
                Console.Write('*');
                if (col==(n-1)/2-1)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                Console.Write('*');
                for (int row = 2; row < (n) * 2; row++)
                {
                    Console.Write(@"\");
                }
                Console.WriteLine('*');
            }
            Console.Write(new string('*', starsFR));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', starsFR));
        }
    }
}
