using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vryhche_I_Neshto_Si
{
    class Program
    {
        static void Main(string[] args)
        {
            int vryhche = 0;
            int dolche = 0;
            int[] a = new int[10000];
            int num = int.Parse(Console.ReadLine());
            int n = 1;
            while (num != 0)
            {
                a[n] = num;
                n++;
                num = int.Parse(Console.ReadLine());
                a[n] = num;
                n++;
                num = int.Parse(Console.ReadLine());
                a[n] = num;
                n++;
                if (a[n - 1] < a[n - 2] && a[n - 1] < a[n])
                {
                    dolche++;
                }
                if (a[n-1] > a[n - 2] && a[n-1] > a[n])
                {
                    vryhche++;
                }
            }
            Console.WriteLine(vryhche + " d " + dolche);
        }
    }
}
