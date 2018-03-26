using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            string a;
            string b;
            string c;

            a = Console.ReadLine();

            int inputA = Convert.ToInt32(a);
            Console.WriteLine(String.Format("{0:0}", i + inputA));

            b = Console.ReadLine();

            double inputB = Convert.ToDouble(b);
            Console.WriteLine(String.Format("{0:0.0}", d + inputB));

            c = Console.ReadLine();

            Console.WriteLine(s + c);
            Console.ReadKey();

        }
    }
    
}


