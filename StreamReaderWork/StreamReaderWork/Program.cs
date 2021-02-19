using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReaderWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
          //  Encoding encoder = Encoding.GetEncoding(UTF8);
            StreamReader sr = new StreamReader(@"..\..\..\neshto.txt" );
            string fileContent = sr.ReadToEnd();
            Console.WriteLine(fileContent);
            sr.Close();
        }
    }
}
