using System;
using System.Collections.Generic;
using System.Linq;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' '); // house range
            int s = Convert.ToInt32(st[0]);
            int t = Convert.ToInt32(st[1]);
            string[] ab = Console.ReadLine().Split(' '); //positions of trees
            int a = Convert.ToInt32(ab[0]);
            int b = Convert.ToInt32(ab[1]);
            string[] mn = Console.ReadLine().Split(' '); //number of falling fruits
            int m = Convert.ToInt32(mn[0]);
            int n = Convert.ToInt32(mn[1]);
            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp)); //distance of falling apples
            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp)); //distance of falling oranges

            countApplesAndOranges(s, t, a, b, apples, oranges); 
            Console.WriteLine();
            Console.ReadKey();
        }

        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int[] houseRange = new int[2] { s, t };
            List<int> appleList = new List<int>();
            List<int> orangeList = new List<int>();
            int lenghtToApple = s - a;
            int lenghtToOrange = b - t;
            
            for(int i=0; i<apples.Length; i++)
            {
                if(apples[i]>0)
                {
                    if(apples[i]+a>=s && apples[i]+a<=t)
                    {
                        appleList.Add(apples[i]);
                    }
                }
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                if (oranges[i] < 0)
                {
                    if (oranges[i]+b<=t && oranges[i]+b>=s)
                    {
                        orangeList.Add(oranges[i]);
                    }
                }
            }
            int number1 = appleList.Count();
            int number2 = orangeList.Count();

            Console.WriteLine("Number of apples: {0} \nNumber of oranges: {1}", number1, number2);
            Console.ReadKey();
        }

    }
}
