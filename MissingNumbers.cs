//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MissingNumbers
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = Convert.ToInt32(Console.ReadLine());
//            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
//            int m = Convert.ToInt32(Console.ReadLine());
//            int[] brr = Array.ConvertAll(Console.ReadLine().Split(' '), brrTemp => Convert.ToInt32(brrTemp));

//            Stopwatch stopwatch = new Stopwatch();
//            stopwatch.Start();

//            int[] result = missingNumbers(arr, brr);

//            foreach(var item in result)
//            {
//                Console.WriteLine("Diff: " + item);
//            }

//            stopwatch.Stop();
//            Console.WriteLine(stopwatch.ElapsedMilliseconds);

//            Console.ReadKey();
//        }

//        static int[] missingNumbers(int[] arr, int[] brr)
//        {
//            List<int> resultList = new List<int>();

//            int dlugosc = brr.Length;
//            if(brr.Max() > brr.Length)
//            {
//                dlugosc = brr.Max();
//            }

//            Console.WriteLine("Lenght: " + dlugosc);
            
//            for (int i = 0; i < dlugosc+1; i++)
//            {
//                if (arr.Count(x => x == i) != brr.Count(x => x == i))
//                {
//                    resultList.Add(i);
//                }
//            }
//            return resultList.ToArray();
//        }
//    }
//}
