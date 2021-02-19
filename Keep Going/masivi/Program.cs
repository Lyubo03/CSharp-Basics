using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] grades = new int[50];
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            double sum = 0;
            while (n!=0)
            {
                grades [counter] = n;
                counter++;
                n = int.Parse(Console.ReadLine());
            }
            int del = counter;
            while (counter>=0)
            {
                sum += grades[counter];
                counter--;
            }
            Console.WriteLine(sum/del);
        }
    }
}
