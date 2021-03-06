using System;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.Write("Ex25 - This program will give the factorial for a given integer.\nPlease type in an integer: ");
            int intNumber = Convert.ToInt32(Console.ReadLine());
            int intFactorial = 1;

            /*
            // Code using increment counter
            if(intNumber == 0)
            {
                intFactorial = 0;
            }
            else
            {
                for (int i = 1; i <= intNumber; i++)
                {
                    intFactorial = intFactorial * i;
                }
            }
            */

            // Code using decrement counter
            if(intNumber == 0)
            {
                intFactorial = 0;
            }
            else
            {
                for (int j = intNumber; j > 0; j--)
                {
                    intFactorial = intFactorial * j;
                }
            }

//            Console.WriteLine("The factorial for {0} is {1}", intNumber, intFactorial);
            Console.WriteLine(intFactorial);
        }
    }
}
