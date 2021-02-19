using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void FirstPart(int a)
        {

            for (int row = 1; row <= a; row++)
            {

                for (int col = a-1; col <= row; col++)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine(a + " ");
            }
        }
        static void SeconPart(int a)
        {
            for (int row = 1; row <= a; row++)
            {
                for (int col = a-1; col >= row; col--)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine(a + " ");
            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
          //FirstPart(a);
            SeconPart(a);
        }
    }
}
