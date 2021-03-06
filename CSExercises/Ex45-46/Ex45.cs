using System;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex45 - Breaking a user defined amount (dollar.cents) nearest to 5 cents into the least amount of coins of denominations 100, 50, 20 ,10 and 5 cents.");
            Console.Write("Please type in an amount rounded to the nearest 5 cents: ");

            bool unaccepted = true;
            double dblAmount = 0.0;

            do
            {
                try
                {
                    dblAmount = Convert.ToDouble(Console.ReadLine());

                    if ((dblAmount * 100) % 5 != 0.0)
                        dblAmount = (Math.Round(dblAmount * 10))/10;

                    unaccepted = false;
                }
                catch
                {
                    unaccepted = true;
                }

            } while (unaccepted);

//            Console.WriteLine("You entered {0:c}", dblAmount);

            int[,] intArrCount = new int[,] { {100,0}, {50,0}, {20,0}, {10,0}, {5,0} };
            int i, j;
//            Console.WriteLine("intArrCount[].Length = {0}", intArrCount.Length); // returns 10

            BreakIntoCoins(ref intArrCount, intArrCount[0,0], dblAmount);

            for (i = 0; i < (intArrCount.Length / 2); i++)
            {
                j = 0;
                while (intArrCount[i, 1] > j)
                {
                    Console.WriteLine(intArrCount[i, 0] + "c");
                    j++;
                }
            }

        } // end main

        public static void BreakIntoCoins(ref int[,] intArrCount, int currentCoin, double dblAmount)
        {
            double dblNewAmount = dblAmount * 100;
            int intCurrentCount = 0;

            while (dblNewAmount >= currentCoin)
            {
                intCurrentCount++;
                dblNewAmount = dblNewAmount - currentCoin;
            }

            dblNewAmount = dblNewAmount / 100;
         
            int i = 0;
            do {
                if(currentCoin == intArrCount[i,0]) {
                    intArrCount[i, 1] = intCurrentCount;

                    if (i+1 < (intArrCount.Length / 2))
                        BreakIntoCoins(ref intArrCount, intArrCount[i+1, 0], dblNewAmount);
                }
                i++;
            } while(i < (intArrCount.Length / 2));
            
        } // end BreakIntoChains
    }
}
