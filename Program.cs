using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        public static long MAX = 100000;

        static void Main(string[] args)
        {
            List<long> primes = getDoubledPrimes(MAX);
            List<long> palindromesList = new List<long>();
            foreach (long i in primes)
            {
                bool palindrome = IsPalindrome(i);
                if (palindrome)
                {
                    palindromesList.Add(i);
                    Console.WriteLine(i);
                }
            }
                long maxValue = palindromesList.Max();
                Console.WriteLine("This is the biggest palindrome: " + maxValue);

            Console.ReadKey();
        }

        static List<long> getDoubledPrimes(long max)
        {
            List<long> primesList = new List<long>();
            bool isPrime = true;
            for (long i = 2; i < max; i++)
            {
                for (long j = 2; j < i / 2; j++)
                {

                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    primesList.Add(i*i);
                   // Console.WriteLine(i*i);
                }
                isPrime = true;
            }
            return primesList;

        }

        public static bool IsPalindrome(long num)
        {
            long n = num;
            long rev = 0;
            while (n > 0)
            {
                long dig = n % 10;
                rev = rev * 10 + dig;
                n = n / 10;
            }
            return num == rev;
        }
    }
}