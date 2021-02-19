using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metohti
{
    class Program
    {
        private static void PrintHeader()
        {
            Console.Write("CASH RECEIPT" + "\n" +
                              "------------" + "\n"
                              );
        }
        private static void PrintBody()
        {
            Console.Write(
                              "Charged to_________  \n" +
                              "Received by__________  \n");
        }
        private static void PrintFooter()
        {
            Console.Write("--------------------- \n" +
                              "\u00A9" + " Softuni" + "\n");
        }
        static void Main(string[] args)
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
    }
}
