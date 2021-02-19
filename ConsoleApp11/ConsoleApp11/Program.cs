using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static bool IsSimple(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    //Console.Write(i+  " ");
                    return false;
                }
            }
                return true ;
        }
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            

            int n = int.Parse(Console.ReadLine());
            int change = 0;
            if (m > n)
            {
                change = m;
                m = n;
                n = change;
            }
            int counter = 1;
            while (m < n)
            {
                   
                Console.WriteLine("Line " + counter + ": " + IsSimple(m));
                m++; counter++;
            }
            ReadKey();
        }

        private static void ReadKey()
        {
            throw new NotImplementedException();
        }
    }
}
