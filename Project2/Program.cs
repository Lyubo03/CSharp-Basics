using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sec = double.Parse(Console.ReadLine());
            double sec2 = double.Parse(Console.ReadLine());
            double sec3 = double.Parse(Console.ReadLine());
            double result = sec + sec2 + sec3;
            double minuti = result / 60;
            double sekundi = result % 60;
            if (sekundi<9)
            {
                Console.WriteLine(minuti + "0" + ":" + sekundi);
            }

        }
    }
}
