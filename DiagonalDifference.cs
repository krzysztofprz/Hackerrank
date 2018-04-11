using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        static int DiagonalDifference(int[][] a)
        {            
            int[] firstArray = new int[a.Length];
            int[] secondArray = new int[a.Length];            

            for (int i = 0; i < a.Length; i++)
            {
                firstArray[i] = a[i][i];
                //Console.WriteLine("liczby pierwsze: " + a[i][i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                secondArray[i] = a[i][a.Length - i - 1];
                //Console.WriteLine("liczby drugie: " + a[i][a.Length-i-1]);
            }

            int firstArrayResult = firstArray.Sum();
            int secondArrayResult = secondArray.Sum();
            //Console.WriteLine("wynik pierwszy: " + firstArrayResult);
            //Console.WriteLine("wynik drugi: " + secondArrayResult);
            int result = Math.Abs(firstArrayResult - secondArrayResult);
            return result;
        }

        static void Main(string[] args)
        {
           // TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[][] a = new int[n][];

            for (int aRowItr = 0; aRowItr < n; aRowItr++)
            {
                a[aRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            }

            int DiagonalDifferenceResult = DiagonalDifference(a);
            //Console.WriteLine(DiagonalDifferenceResult);
            //Console.ReadKey();
            
            //tw.WriteLine(result);
            
            //tw.Flush();
            //tw.Close();
        }
    }
}

