using System;

using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex40 - Program to use own SquareRoot module to printout the squareroots of the integers 1-25:");

            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine("{0:0.00000}", SQT(i));
            }
        }

        public static double SQT(int intNumber)
        {
            // Console.Write("Ex24 - Find the squareroot of a user given number N\nPlease provide an integer: ");
            // int intNumber = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            double dblGuess = 1.0 * rnd.Next(1, intNumber + 1);

            double dblSquare, dblLower, dblHigher, dblDifference;

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

            while (dblDifference > 0.000009)
            {
//                Console.WriteLine("Current Guess = {0}", dblGuess);

                dblGuess = (dblGuess + (intNumber / dblGuess)) / 2;

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
//            Console.WriteLine("{0:0.00000}", dblGuess);
            return dblGuess;
        }
    }
}
