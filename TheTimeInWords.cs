using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTimeInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());                    

            string result = timeInWords(h, m);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        static string timeInWords(int h, int m)
        {
            string a = "";
            string b = "";
            string past = "past";
            string to = "to";
            string s = "";
            string clock = "o' clock";

            switch (h)
            {
                case 1:
                    a = "one";
                    break;
                case 2:
                    a = "two";
                    break;
                case 3:
                    a = "three";
                    break;
                case 4:
                    a = "four";
                    break;
                case 5:
                    a = "five";
                    break;
                case 6:
                    a = "six";
                    break;
                case 7:
                    a = "seven";
                    break;
                case 8:
                    a = "eight";
                    break;
                case 9:
                    a = "nine";
                    break;
                case 10:
                    a = "ten";
                    break;
                case 11:
                    a = "eleven";
                    break;
                case 12:
                    a = "twelve";
                    break;
            }

            switch(m)
            {
                case 01:
                case 59:
                    b = "one minute";
                    break;
                case 02:
                case 58:
                    b = "two minutes";
                    break;
                case 03:
                case 57:
                    b = "three minutes";
                    break;
                case 04:
                case 56:
                    b = "four minutes";
                    break;
                case 05:
                case 55:
                    b = "five minutes";
                    break;
                case 06:
                case 54:
                    b = "six minutes";
                    break;
                case 07:
                case 53:
                    b = "seven minutes";
                    break;
                case 08:
                case 52:
                    b = "eight minutes";
                    break;
                case 09:
                case 51:
                    b = "nine minutes";
                    break;
                case 10:
                case 50:
                    b = "ten minutes";
                    break;
                case 11:
                case 49:
                    b = "eleven minutes";
                    break;
                case 12:
                case 48:
                    b = "twelve minutes";
                    break;
                case 13:
                case 47:
                    b = "thirteen minutes";
                    break;
                case 14:
                case 46:
                    b = "fourteen minutes";
                    break;
                case 15:
                case 45:
                    b = "quarter";
                    break;
                case 16:
                case 44:
                    b = "sixteen minutes";
                    break;
                case 17:
                case 43:
                    b = "seventeen minutes";
                    break;
                case 18:
                case 42:
                    b = "eighteen minutes";
                    break;
                case 19:
                case 41:
                    b = "nineteen minutes";
                    break;
                case 20:
                case 40:
                    b = "twenty minutes";
                    break;
                case 21:
                case 39:
                    b = "twenty one minutes";
                    break;
                case 22:
                case 38:
                    b = "twenty two minutes";
                    break;
                case 23:
                case 37:
                    b = "twenty three minutes";
                    break;
                case 24:
                case 36:
                    b = "twenty four minutes";
                    break;
                case 25:
                case 35:
                    b = "twenty five minutes";
                    break;
                case 26:
                case 34:
                    b = "twenty six minutes";
                    break;
                case 27:
                case 33:
                    b = "tenty seven minutes";
                    break;
                case 28:
                case 32:
                    b = "twenty eight minutes";
                    break;
                case 29:
                case 31:
                    b = "twenty nine minutes";
                    break;
                case 30:
                    b = "half";
                    break;               
            }

            if(m > 30 && m <= 59)
            {
                switch (h)
                {
                    case 1:
                        a = "two";
                        break;
                    case 2:
                        a = "three";
                        break;
                    case 3:
                        a = "four";
                        break;
                    case 4:
                        a = "five";
                        break;
                    case 5:
                        a = "six";
                        break;
                    case 6:
                        a = "seven";
                        break;
                    case 7:
                        a = "eight";
                        break;
                    case 8:
                        a = "nine";
                        break;
                    case 9:
                        a = "ten";
                        break;
                    case 10:
                        a = "eleven";
                        break;
                    case 11:
                        a = "twelve";
                        break;
                    case 12:
                        a = "one";
                        break;
                }
                s = b + " " + to + " " + a;
            }
            else if(m < 30 && m >= 1)
            {                
                s = b + " " + past + " " + a;
            }
            else if(m == 0)
            {
                s = a + " " + clock;
            }
            else if(m == 30)
            {
                s = "half " + past + " " + a;
            }
            return s;
        }
    }
}
