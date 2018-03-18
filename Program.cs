using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        public static int MAX = 100000;

        static void Main(string[] args)
        {
            List<int> primes = getDoubledPrimes(MAX);
            List<int> palindromesList = new List<int>();
            foreach (int i in primes)
            {
                bool palindrome = IsPalindrome(i);
                if (palindrome)
                {
                    palindromesList.Add(i);
                }
            }

            foreach(int p in palindromesList)
            {
                int maxValue = palindromesList.Max();
                Console.WriteLine("This is the biggest palindrome: " + maxValue);
                break;
            }
            Console.ReadKey();
        }

        static List<int> getDoubledPrimes(int max)
        {
            List<int> primesList = new List<int>();
            bool isPrime = true;
            for (int i = 2; i < max; i++)
            {
                for (int j = 2; j < i / 2; j++)
                {

                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    primesList.Add(i * i);
                }
                isPrime = true;
            }
            return primesList;

        }

        public static bool IsPalindrome(int num)
        {
            int n = num;
            int rev = 0;
            while (n > 0)
            {
                int dig = n % 10;
                rev = rev * 10 + dig;
                n = n / 10;
            }
            return num == rev;
        }        
    }
}


