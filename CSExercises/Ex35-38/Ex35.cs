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

            for (i = 0; i < strLowered.Length; i++)
            {
                for(j=0; j<chrArrVowel.Length; j++)
                {
                    if (strLowered[i] == chrArrVowel[j])
                        intVowelCount++;
                }
            }

            Console.WriteLine("Total number of vowels: {0}", intVowelCount);
        }
    }
}
