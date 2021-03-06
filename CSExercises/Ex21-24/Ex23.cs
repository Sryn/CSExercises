using System;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex23 - Guess the Number Game");
            Random rnd = new Random();
            int intGuess, counter = 1;
            int intRnd = rnd.Next(0, 10);
            string strPraise, strGuess = "guesses";

            Console.Write("Make a guess (0-9): ");
            intGuess = Convert.ToInt32(Console.ReadLine());

            while (intGuess != intRnd)
            {
                counter++;
                Console.Write("Try again: ");
                intGuess = Convert.ToInt32(Console.ReadLine());
            } 
/**/
// This switch structure is how I understand the question
            switch(counter)
            {
                case 1:
                case 2: strPraise = "You are a Wizard!"; break;
                case 3:
                case 4:
                case 5: strPraise = "You are a good guess."; break;
                default:
                    strPraise = "You are lousy!"; break;
            }
/**/
            /*
            // This switch structure is how the automated test score perfectly
            switch (counter)
            {
                case 1: strPraise = "You are a Wizard!"; break;
                case 2:
                case 3:
                case 4: strPraise = "You are a good guess."; break;
                default:
                    strPraise = "You are lousy!"; break;
            }
            */
            if (counter == 1)
            {
                strGuess = "guess";
            }
            
            Console.WriteLine("{0} It took you {1} {2}.", strPraise, counter, strGuess);

        }
    }
}
