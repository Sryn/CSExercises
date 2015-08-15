using System;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.Write("Ex15 - Please type a three digit integer within the range 100-999 and we'll determine whether it is an Armstrong number or not: ");
            int aNumber = Convert.ToInt32(Console.ReadLine());
            if ((aNumber < 100) || (aNumber > 999))
                Console.WriteLine("Number entered not accepted");
            else
            {
                double firstDigit, secondDigit, thirdDigit;
                firstDigit = aNumber / 100;
                secondDigit = (aNumber / 10) - (firstDigit * 10);
                thirdDigit = aNumber - (firstDigit * 100) - (secondDigit * 10);
                if (aNumber == Math.Pow(firstDigit, 3) + Math.Pow(secondDigit, 3) + Math.Pow(thirdDigit, 3))
                    Console.WriteLine("Armstrong Number");
                else
                    Console.WriteLine("Not Armstrong Number");
            }
        }
    }
}