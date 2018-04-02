using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longArraySum
{
    class Program
    {

        static long aVeryBigSum(int n, long[] ar)
        {

            long[] firstArray = ar;
            firstArray = new long[n];
            long sum = ar.Sum();
            Console.WriteLine(sum);
            return sum;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long result = aVeryBigSum(n, ar);

            Console.ReadKey();
        }
    }
}
