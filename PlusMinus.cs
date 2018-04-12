using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //repair this functionality!!

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            PlusMinus(arr);
            
            Console.ReadKey();
        }

        static void PlusMinus(int[] numbersArray)
        {
            var biggerThanZero = from num in numbersArray
                                 where num > 0
                                 select num;

            var smallerThanZero = from num in numbersArray
                                  where num < 0
                                  select num;

            var equalToZero = from num in numbersArray
                              where num == 0
                              select num;

            double countEqualToZero = equalToZero.Count();
            //Console.WriteLine(countEqualToZero);

            double countSmallerThanZero = smallerThanZero.Count();
            //Console.WriteLine(countSmallerThanZero);

            double countBiggerThanZero = biggerThanZero.Count();
            //Console.WriteLine(countBiggerThanZero);

            double countNumbersArray = numbersArray.Count();
            //Console.WriteLine(countNumbersArray);

            double resultLower = countSmallerThanZero / countNumbersArray;
            double resultBigger = countBiggerThanZero / countNumbersArray;
            double resultEqual = countEqualToZero / countNumbersArray;

            Console.WriteLine("{0:F5}", resultBigger);
            Console.WriteLine("{0:F5}", resultLower);
            Console.WriteLine("{0:F5}", resultEqual);

            return;
        }
    }
}
