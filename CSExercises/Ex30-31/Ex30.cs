using System;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex30 - This program will print out all the prime numbers between 5 and 10,000 inclusive.");

            string strResult;
            int i, j;

            // i is current potential prime number
            for (i = 5; i <= 10000; i++ )
            {
                strResult = "Prime";
                j = 2;
//                Console.WriteLine("\ni = {0}", i);

                // j is potential factor
                while ((strResult == "Prime") && (j <= (i/2)))
                {
//                    Console.Write("j = {0} ", j);

                    if ((i % j) == 0)
                    {
                        strResult = "Not Prime";
                    }
                    j++;
                }

                if(strResult == "Prime")
                    Console.WriteLine(i);

            }
        }
    }
}
