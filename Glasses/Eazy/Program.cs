using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eazy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int between = 0;
            int left = (n / 2) - 1;
            int right = (n / 2) - 1;
            if (n < 4 && n % 3 == 0)
            {
                left = n / 2;
                right = n / 2;
            }
            while (left >= 0)
            {
                Console.Write(new string('-', left));
                Console.Write('*');
                Console.Write(new string('-', between));
                Console.Write('*');
                Console.WriteLine(new string('-', right));
                between += 2;
                right--;
                left--;
            }
            left = 1;
            right = 1;
            between -= 4;
            while (between >= 0)
            {
                Console.Write(new string('-', left));
                Console.Write('*');
                Console.Write(new string('-', between));
                Console.Write('*');
                Console.WriteLine(new string('-', right));
                between -= 2;
                right++;
                left++;
            }
        }
    }
}
