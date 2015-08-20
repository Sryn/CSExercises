using System;

namespace CSExercises
{
    public class Ex39
    {
        public static void Main()
        {
            Console.WriteLine("Ex39 - Program to build a Factorial() sub-Module");

            Boolean booUnobtained = true;
            long lonNumber = 0;

            do{
                try{
                    Console.Write("Please enter an integer to find the factorial of: ");
                    lonNumber = Convert.ToInt64(Console.ReadLine());
                    booUnobtained = false;
                } catch {
                    booUnobtained = true;
                }
            }while(booUnobtained);

            Console.WriteLine(Factorial(lonNumber));
        }

        public static long Factorial(long n)
        {
            long lonResult = 1;

            for (int i = 1; i <= n; i++)
            {
                lonResult = lonResult * i;
            }
                return lonResult;
        }
    }
}
