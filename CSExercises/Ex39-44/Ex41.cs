using System;

namespace CSExercises
{
    public class Ex41
    {
        public static void Main()
        {
            Console.WriteLine("Ex41 - Program to find whether a second user given string exists in the first user given string (case insensitive):");
            Console.WriteLine("Please type the first string: ");
            string strFirst = Console.ReadLine();
            Console.WriteLine("Please type the second string: ");
            string strSecond = Console.ReadLine();
            Console.WriteLine(InString( strFirst.ToLower(), strSecond.ToLower()));
        }

        public static bool InString(string s1, string s2)
        {
            int i = 0, j = 0;
            bool booUnproven = true;

            while (booUnproven && ((s1.Length - i) >= s2.Length))
            {
                j = 0;

                while (booUnproven && (s1.Substring(i+j, 1) == s2.Substring(j, 1)))
                {
                    if (s2.Length-1 == j)
                    {
                        booUnproven = false;
                    }

                    j++;
                }

                i++;
            }

            return !booUnproven;
        }
    }
}
