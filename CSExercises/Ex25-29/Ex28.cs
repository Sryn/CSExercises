using System;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex28 - Input an integer and this program will determine if that integer is a prime number or not.");

            Console.Write("Please type a positive integer: ");
            int intNumber = Convert.ToInt32(Console.ReadLine());

            string strResult = "Prime";
            int i = 2;

            while((strResult == "Prime") && (i<intNumber))
            {
                if((intNumber%i) == 0)
                {
                    strResult = "Not Prime";
                }
                i++;
            }

            if ((intNumber == 0) || (intNumber == 1))
            {
                Console.WriteLine("Not Prime");
            }
            else
                Console.WriteLine(strResult);
        }
    }
}
