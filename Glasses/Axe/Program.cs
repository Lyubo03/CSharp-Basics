using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int starsL = n * 3;
            int starsR = (n * 2) - 2;
            int between = 0;
            int lenght = n - 1;
            if (n % 2 == 0) lenght = n;
            for (int row = 0; row < lenght; row++)
            {
                Console.Write(new string('-', starsL));
                Console.Write('*');
                Console.Write(new string('-', between));
                Console.Write('*');
                Console.WriteLine(new string('-', starsR));
                between++;
                starsR--;
                else if (n > 7 && row >= (n * 2) - 6)
                {
                    starsL--; starsR--; between += 2;
                }
            }
            lenght = n / 2;
            for (int row = 0; row < lenght; row++)
            {
                Console.Write(new string('-', starsL));
                Console.Write(new string('-', between));
                Console.Write('*');
                Console.WriteLine(new string('-', starsR));
            }
            if (n % 2 == 0)
            {
                between = (n * 2);
            }
            else
            {
                between = (n * 2) - 3;
            }
            if (starsR % 2 == 0)
            {
                starsR = starsR / 2;
            }
            else { starsR = (starsR / 2) + 1; }
            starsL--;
            Console.Write(new string('-', starsL));
            Console.Write(new string('*', between));
            Console.WriteLine(new string('-', starsR));
        }
    }
}
