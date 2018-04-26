using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCandle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = BirthdayCakeCandles(n, ar);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int BirthdayCakeCandles(int n, int[] ar)
        {
            int[] firstArray = ar;
            int maxValue = firstArray.Max();

            var maxQuery = (from val in firstArray
                           where val == maxValue
                           select val).Count();
            return maxQuery;
        }
    }
}
