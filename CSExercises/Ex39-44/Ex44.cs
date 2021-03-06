using System;

namespace CSExercises
{
    public class Ex44
    {
        public static void Main()
        {
            Console.WriteLine("Ex44 - Program to replace, case sensitively, in the first user given text any occurence of the first user given character with the second user given character, and prints out on the screen the replaced text.");

            Console.WriteLine("Please type the text: ");
            string strFirst = Console.ReadLine();

            Console.WriteLine("Please type the character to find: ");
            char chr1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Please type the character to replace to: ");
            char chr2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(Substitute(strFirst, chr1, chr2));
        }

        public static string Substitute(string s, char c1, char c2)
        {
            string strResult = "";

            for(int i=0; i < s.Length; i++) {
                if (s[i] == c1)
                    strResult = strResult.Insert(i, Convert.ToString(c2));
                else
                    strResult = strResult.Insert(i, Convert.ToString(s[i]));
            }

                return strResult;
        }
    }
}
