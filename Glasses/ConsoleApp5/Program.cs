using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string filling = new string('-', (input / 2));
            string diamond = "*";
            string topLine = filling + diamond + filling;
            Console.WriteLine(topLine);
            int count;
            for (count = 1; count < (input - 2); count++)
            {
                if (count % 2 == 0)
                {
                    string draw = new string('-', ((input / 2) - (count / 2)));
                    string midDraw = new string('-', (count - 1));
                    Console.WriteLine(draw + diamond + midDraw + diamond + draw);
                }
            }
            string middle = new string('-', (input - 2));
            Console.WriteLine(diamond + middle + diamond);
            for (count = (input - 3); count > 1; count--)
            {
                if (count % 2 == 0)
                {
                    string draw = new string('-', ((input / 2) - (count / 2)));
                    string midDraw = new string('-', (count - 1));
                    Console.WriteLine(draw + diamond + midDraw + diamond + draw);
                }
            }
            Console.WriteLine(topLine);
        }
    }
}
