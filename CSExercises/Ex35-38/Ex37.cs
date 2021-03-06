using System;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.Write("Ex37 - This program will take the user text input and convert it to Title Case.\nPlease type in your text: ");

            string strInput = Console.ReadLine();
            string strUppered = strInput.ToUpper();
            char[] chrArrTitled = new char[strInput.Length];
            int i;
            Boolean previousSpace = true;

            for (i = 0; i < strInput.Length; i++)
            {
                if (char.IsLetter(strInput[i]))
                {
                    if (previousSpace)
                    {
                        chrArrTitled[i] = strUppered[i];
                    }
                    else
                    {
                        chrArrTitled[i] = strInput[i];
                    }
                    previousSpace = false;
                }
                else if (char.IsWhiteSpace(strInput[i]))
                {
                    previousSpace = true;
                    chrArrTitled[i] = strInput[i];
                }
                else
                {
                    previousSpace = false;
                    chrArrTitled[i] = strInput[i];
                }
            }

            for (i = 0; i < strInput.Length; i++)
                Console.Write(chrArrTitled[i]);

            Console.WriteLine();
        }
    }
}
