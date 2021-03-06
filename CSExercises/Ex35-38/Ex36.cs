using System;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.Write("Ex36 - This program will take the user text input and determine if its a palindrome or not.\nPlease type in your text: ");

            string strInput = Console.ReadLine();
            string strLowered = strInput.ToLower();
            char[] chrArrAcceptedChars = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','0','1','2','3','4','5','6','7','8','9'};
            char[] strCleaned = new char[strLowered.Length];
            Boolean isPalindrome = true, isHalf = true;
            int i, j, k=0;

            // only accept abc..z and 012..9
            for (i = 0; i < strLowered.Length; i++)
            {
                for (j = 0; j < chrArrAcceptedChars.Length; j++)
                {
                    if (strLowered[i] == chrArrAcceptedChars[j])
                        strCleaned[k++] = strLowered[i];
                }
            }

            /*
            // This was the part a. version
            i = 0;
            while (isPalindrome && isHalf)
            {
                if (strLowered[i] != strLowered[strLowered.Length - 1 - i])
                    isPalindrome = false;
                
                if(i>(strLowered.Length/2))
                    isHalf = false;

                i++;
            }
            */

            i = 0;
            while (isPalindrome && isHalf)
            {
                if (strCleaned[i] != strCleaned[k - 1 - i])
                    isPalindrome = false;

                if (i > k / 2)
                    isHalf = false;

                i++;
            }


            if (isPalindrome)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
    }
}
