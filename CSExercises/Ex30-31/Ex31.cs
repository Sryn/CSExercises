using System;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex31 - This program will print out all the perfect numbers between 1 and 1,000 inclusive.");

            int i, j, intSubTotal;

            // i is current potential perfect number
            for (i = 1; i <= 1000; i++)
            {
                j = 1;
                intSubTotal = 0;

                // j is current potential factor
                while (j <= (i / 2))
                {
                    if (i % j == 0)
                    {
                        intSubTotal = intSubTotal + j;
                    }
                    j++;
                }

                if (intSubTotal == i)
                    Console.WriteLine(i);

            }
        }
    }
}
