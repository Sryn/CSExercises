using System;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.Write("Ex16 - Please type your name: ");
            string name = Console.ReadLine();
            Console.Write("Please type your gender (M/F): ");
            char gender = Convert.ToChar(Console.ReadLine());
            if(gender == 'M')
                Console.WriteLine("Good Morning Mr. {0}", name);
            else if(gender == 'F')
                Console.WriteLine("Good Morning Ms. {0}", name);
            else
                Console.WriteLine("Undefined gender {0}", gender);
        }
    }
}