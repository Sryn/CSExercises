using System;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Ex21 - Checks to see if you type the lucky number");

            do
            {
                Console.Write("Please type a multidigit integer: ");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number != 88);
            Console.WriteLine("Lucky you...");
        }
    }
}
