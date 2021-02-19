using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zpitni_zadachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
             if (day == "day" && 20>=n)
             {
                 Console.WriteLine(0.70 + n*0.79);
             }
             if (day == "night" && n<=20)
             {
                 Console.WriteLine(0.70 + n*0.90);
             }
            
            if (n>20 && n<100)
            {
                Console.WriteLine(n*0.09);
            }
            else 
            {
                Console.WriteLine(n*0.06);
            }
        }
    }
}
