using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSmallestPossibleInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { };
            int res = Solution(arr);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        public static int Solution(int[] A)
        {
            int result = 0;
            Array.Sort(A);
            int[] noDuplicates = A.Distinct().ToArray();
            noDuplicates = noDuplicates.Where(x => x != 0).ToArray();

            if (noDuplicates.Count() == 0 || noDuplicates.Max() < 1)
                return result = 1;
            else
            {
                noDuplicates = noDuplicates.Where(x => x > 0).ToArray();

                for (int i = 0; i < noDuplicates.Count(); i++)
                {
                    if (i + 1 != noDuplicates[i])
                    {
                        result = i + 1;
                        break;
                    }
                    else
                        result = noDuplicates.Max() + 1;
                }
            }

            return result;
        }
    }
}
