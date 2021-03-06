using System;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.Write("Ex24 - Find the squareroot of a user given number N\nPlease provide an integer: ");
            int intNumber = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            double dblGuess = 1.0 * rnd.Next(1, intNumber + 1);

            double dblSquare, dblLower, dblHigher, dblDifference;

            dblSquare = dblGuess * dblGuess;

            if(dblSquare > intNumber)
            {
                dblHigher = dblSquare;
                dblLower = intNumber * 1.0;
            }
            else
            {
                dblHigher = intNumber * 1.0;
                dblLower = dblSquare;
            }

            dblDifference = dblHigher - dblLower;

            while(dblDifference > 0.000009)
            {
                Console.WriteLine("Current Guess = {0}", dblGuess);

                dblGuess = (dblGuess + (intNumber/dblGuess))/2;

                dblSquare = dblGuess * dblGuess;

                if (dblSquare > intNumber)
                {
                    dblHigher = dblSquare;
                    dblLower = intNumber * 1.0;
                }
                else
                {
                    dblHigher = intNumber * 1.0;
                    dblLower = dblSquare;
                }

                dblDifference = dblHigher - dblLower;
            }
            Console.WriteLine("{0:0.00000}", dblGuess);
        }
    }
}
