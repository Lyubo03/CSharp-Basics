using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Riter
{
    class Program
    {
        static void writeDigits()
        {
            string fileName = @"..\..\..\chisla.txt";
            string fileHappyDigits = @"..\..\..\HappyDigits.txt";
            Encoding encoder = Encoding.UTF8;
            bool appendToText = false;
            int n;
            StreamReader sr = new StreamReader(fileName, encoder);
            StreamWriter sw = new StreamWriter(fileHappyDigits, appendToText, encoder);
            string line;
            int i = 1;
            while (i <= 100)
            {              
                line = File.ReadAllText(fileName);
                n = int.Parse(line);
                if (isPrime(n)==true)
                {
                    sw.AutoFlush = true;
                    sw.WriteLine(n);
                }
                i++;
            }
            sr.Close();
            sw.Close();
        }
        //Write DIgits
        static void AddDigits()
        {
            Random r = new Random();
            int n;
            Encoding encoder = Encoding.UTF8;
            string fileName = @"..\..\..\chisla.txt";
            bool appendToFile = false;
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }
            else
            {
                File.Delete(fileName);
            }
            StreamWriter sw = new StreamWriter(fileName, appendToFile, encoder);
            for (int i = 0; i < 100; i++)
            {
                n = r.Next(501);
                sw.AutoFlush = true;
                sw.WriteLine(n);
            }
            sw.Close();
        }
        static bool isPrime(int n)
        {
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(false);
                    return false;
                }
            }
            Console.WriteLine(true);
            return true;
        }
        static void Main(string[] args)
        {
            AddDigits();
            writeDigits();
        }
    }
}