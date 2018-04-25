using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Staircase(n);

        }

        static void Staircase(int n)
        {
            string[] firstArray = new string[n];
            string x = "#";

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (i == 0)
                {
                    firstArray[i] = x;
                }
                else
                {
                    firstArray[i] += x + firstArray[i - 1];
                }
            }

            foreach (string item in firstArray)
            {
                Console.WriteLine(item.PadLeft(n));
            }
            
            Console.ReadKey();
        }

    }
}
