using System;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex35 - This program will count and output the vowels from a user input phrase: ");

            string strInput = Console.ReadLine();
            string strLowered = strInput.ToLower();
            int i, j, intVowelCount = 0;
            char[] chrArrVowel = new char[] {'a','e','i','o','u'};
            int[] intArrEachVowelCount = new int[] { 0, 0, 0, 0, 0 };

            for (i = 0; i < strLowered.Length; i++)
            {
                for (j = 0; j < chrArrVowel.Length; j++)
                {
                    if (strLowered[i] == chrArrVowel[j])
                    {
                        intVowelCount++;
                        intArrEachVowelCount[j]++;
                    }
                }
            }

            if (strInput[0] != ' ')
            {
                Console.WriteLine("Total number of vowels: {0}", intVowelCount);
            }
            else
            {
                for(i=0; i<chrArrVowel.Length; i++)
                {
                    Console.WriteLine("Number of {0}: {1}", chrArrVowel[i], intArrEachVowelCount[i]);
                }
            }


        }
    }
}
