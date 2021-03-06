using System;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex29 - This program will determine if a given positive integer is a Perfect number or not.  A Perfect Number is a number where its factors, including number one, adds up to the number itself.");
            Console.Write("Please type a positive integer: ");
            int intNumber = Convert.ToInt32(Console.ReadLine());
            int i=1, intSubTotal = 0;

            if(intNumber <= 0)
            {
                Console.WriteLine("Invalid Given Integer");
            }
            else
            {
                while(i <= (intNumber/2))
                {
                    if(intNumber%i == 0)
                    {
                        intSubTotal = intSubTotal + i;
                    }
                    i++;
                }

                if (intSubTotal == intNumber)
                    Console.WriteLine("Perfect Number");
                else
                    Console.WriteLine("Not Perfect Number");

            }
        }
    }
}
