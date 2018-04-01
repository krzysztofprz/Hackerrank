using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayComparison
{
    class Program
    {

        static int[] Solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int[] tripletAlice = { a0, a1, a2 };
            int[] tripletBob = { b0, b1, b2 };

            int alicePoints = 0;
            int bobPoints = 0;

            Console.WriteLine("Alice values: {0}, {1}, {2}", a0, a1, a2);
            Console.WriteLine("Bob values: {0}, {1}, {2}", b0, b1, b2);

            for (int i=0; i < tripletAlice.Length; i++)
            {
                if(tripletAlice[i] > tripletBob[i])
                {
                    alicePoints++;
                }
                else if(tripletAlice[i] < tripletBob[i])
                {
                    bobPoints++;
                }
            }

            int[] result = { alicePoints, bobPoints };         
            Console.WriteLine("Alice score: " + alicePoints);
            Console.WriteLine("Bob score: " + bobPoints);
            return result;
        }

        static void Main(string[] args)
        {
            string[] A0A1A2 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(A0A1A2[0]);
            int a1 = Convert.ToInt32(A0A1A2[1]);
            int a2 = Convert.ToInt32(A0A1A2[2]);

            string[] B0B1B2 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(B0B1B2[0]);
            int b1 = Convert.ToInt32(B0B1B2[1]);
            int b2 = Convert.ToInt32(B0B1B2[2]);

            
            int[] result = Solve(a0, a1, a2, b0, b1, b2);

            Console.ReadKey();
        }
    }
}
