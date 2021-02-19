using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void FirstPart(int n)
        {
            for (int col = 1; col <= n; col++)
            {
                for (int row = 1; row < col; row++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine(col + " ");
            }
        }
        static void SecondPart(int n) 
        {
            for (int col = 1; col < n; col++)
            {
                for (int row = n - 1; row > col; row--)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine(col + " ");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FirstPart(n);
            SecondPart(n);
        }
    }
}
