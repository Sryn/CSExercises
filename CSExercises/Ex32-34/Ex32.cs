using System;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex32 - This program will take input from the user of sales amount for twelve months and output the month for highest sales, lowest sales and the average sales.");

            int intArrSize = 12, intHighest = 0, intLowest = 0, intAverage = 0;
            int[] intArrSales = new int[intArrSize];
            bool undone;

            for (int i = 0; i < intArrSize; i++)
            {
                undone = true;
                do
                {
                    try
                    {
                        Console.Write("Enter sales for month {0}: ", i);
                        intArrSales[i] = Convert.ToInt32(Console.ReadLine());
                        undone = false;
                    }
                    catch
                    {
                        undone = true;
                    }
                } while (undone == true);

                if (intArrSales[intHighest] < intArrSales[i])
                {
                    intHighest = i;
                }

                if (intArrSales[intLowest] > intArrSales[i])
                {
                    intHighest = i;
                }

                intAverage = intAverage + intArrSales[i];
            }

            Console.WriteLine("Maximum Sales : {0}", intHighest);
            Console.WriteLine("Minimum Sales : {0}", intLowest);
            Console.WriteLine("Average Sales : {0}", (1.0*intAverage)/intArrSales.Length);
        }
    }
}
