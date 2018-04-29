using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = TimeConversion(s);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        static string TimeConversion(string s)
        {
            char c = 'P';
            if (s.Contains(c))
            {
                string s1 = s.Remove(s.LastIndexOf(c));
                int first = (int)Char.GetNumericValue(s1[0]);
                int second = (int)Char.GetNumericValue(s1[1]);

                if (first == 1)
                {
                    if (second == 0)
                    {
                        s1 = "22" + s1.Remove(0, 2);
                        return s1;
                    }

                    if (second == 1)
                    {
                        s1 = "23" + s1.Remove(0, 2);
                        return s1;
                    }
                }

                if (first == 0)
                {
                    switch (second)
                    {
                        case 1:
                            s1 = "13" + s1.Remove(0, 2);
                            return s1;
                        case 2:
                            s1 = "14" + s1.Remove(0, 2);
                            return s1;
                        case 3:
                            s1 = "15" + s1.Remove(0, 2);
                            return s1;
                        case 4:
                            s1 = "16" + s1.Remove(0, 2);
                            return s1;
                        case 5:
                            s1 = "17" + s1.Remove(0, 2);
                            return s1;
                        case 6:
                            s1 = "18" + s1.Remove(0, 2);
                            return s1;
                        case 7:
                            s1 = "19" + s1.Remove(0, 2);
                            return s1;
                        case 8:
                            s1 = "20" + s1.Remove(0, 2);
                            return s1;
                        case 9:
                            s1 = "21" + s1.Remove(0, 2);
                            return s1;
                    }
                }
                return s1;
            }

            else
            {
                char d = 'A';
                s = s.Remove(s.LastIndexOf(d));
                int first = (int)Char.GetNumericValue(s[0]);
                int second = (int)Char.GetNumericValue(s[1]);
                if (first == 1 && second == 2)
                {
                        s = "00" + s.Remove(0, 2);
                }
                return s;
            }
        }
    }
}
