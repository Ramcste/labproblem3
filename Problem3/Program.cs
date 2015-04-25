using System;

namespace Problem3
{
    class Program
    {
       
        static void Main()
        {
            int sum1 = 0, sum2 = 0, sum3 = 0;
            
            
            for (int i = 1; i < 10; i++)
            {

                if (i % 3 == 0)
                {
                    sum1 = sum1 + i;
                }

                else if (i % 5 == 0)
                {
                    sum2 = sum2 + i;
                }

                else if (i % 15 == 0)
                {
                    sum3 = sum3 + i;
                }

                
            }
            Console.WriteLine("The sum of multiplies between 3 and 5 is: " + (sum1 + sum2 - sum3));

            Console.ReadKey();
        }
    }
}
