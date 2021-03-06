using System;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex46 - This program will print out a table that show the number of occurences of 50 randomly generated 0-9 integers.");

            int[] intArr0to9 = new int[10];

            GenerateRandom0to9(ref intArr0to9, 50);

//            PrintPartOne(intArr0to9);

            PrintPartTwo(intArr0to9);
        }

        public static void GenerateRandom0to9(ref int[] intArr0to9, int intHowMany)
        {
            Random rnd = new Random();

            for (int i = 0; i < intHowMany; i++)
            {
                int int0to9 = rnd.Next(0, 10);
                intArr0to9[int0to9]++;
            }
        }

        public static void PrintPartOne(int[] intArr0to9)
        {
            Console.WriteLine("\nNumber\tCount");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("  {0}\t", i);
                if (intArr0to9[i] > 9)
                    Console.Write(" {0}", intArr0to9[i]);
                else
                    Console.Write("  {0}", intArr0to9[i]);
                Console.WriteLine();
            }

        }

        public static void PrintPartTwo(int[] intArr0to9)
        {
            Console.WriteLine("\nNumber");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("  {0}  ", i);
                for (int j = 0; j < intArr0to9[i]; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }

        }

    }
}
