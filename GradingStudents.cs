using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type number of students between 1 and 60:");

            string z = Console.ReadLine();

            int n = ControlMethod(z);
 
            while(n<1 || n>60)
            {
                if (n<1 || n>60)
                {
                    try
                    {
                        throw new Exception("Wrong number. Type again number between 1 and 60");
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    z = Console.ReadLine();
                    n = ControlMethod(z);
                }
            }

            Console.WriteLine("Add grades values between 0 and 100:");

            int[] grades = new int[n];

            for (int gradesItr = 0; gradesItr < n; gradesItr++)
            {
                string gItem = Console.ReadLine();
                int x = ControlMethod(gItem);

                while (x < 0 || x > 100)
                {
                    if (x < 0 || x > 100)
                    {
                        try
                        {
                            throw new Exception("Wrong number. Type again number between 0 and 100");
                        }

                        catch (Exception ex1)
                        {
                            Console.WriteLine(ex1.Message);
                        }
                        gItem = Console.ReadLine();
                        x = ControlMethod(gItem);
                    }
                }
                grades[gradesItr] = x;                
            }

            int[] result = GradingStudents(grades);

            for(int k=0; k<result.Length; k++)
            {
                Console.WriteLine("Result no. {0}: " + result[k], k);
            }

            Console.ReadKey();
        }

        static int[] GradingStudents(int[] grades)
        {
                int[] firstArray = grades;
                int[] finalArray = new int[firstArray.Length];
            
                for(int i=0; i<finalArray.Length; i++)
                {
                    if(firstArray[i]<=37)
                    {
                        finalArray[i] = firstArray[i];
                    }

                    else if(firstArray[i]>=37)
                    {
                        int val1 = firstArray[i] % 5;
                        if (val1 == 0)
                        {
                            finalArray[i] = firstArray[i];
                        }
                        else if (val1 !=0)
                        {
                            if(val1>=3)
                            {
                                finalArray[i] = firstArray[i] + (5 - val1);
                            }
                            else if(val1<3)
                            {
                                finalArray[i] = firstArray[i];
                            }
                        }
                    
                    }
                }

            return finalArray;
        }

        static int ControlMethod(string z)
        {
            int c = 0;
            try
            {
                int b = Convert.ToInt32(z);
                c = b;
            }
            catch
            {
                Console.WriteLine("Wrong input. Type number");                
            }
            return c;
        }
    }
}
