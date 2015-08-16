using System;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.Write("Ex17 - Please type your name: ");
            string name = Console.ReadLine();
            Console.Write("Please type your gender (M/F): ");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.Write("Please type your age (years): ");
            int age = Convert.ToInt32(Console.ReadLine());
            string prefix = "undefined";
            if (gender == 'M')
            {
                if (age >= 40)
                    prefix = "Uncle";
                else if (age < 40)
                    prefix = "Mr.";
            }
            else if (gender == 'F')
                if (age >= 40)
                    prefix = "Aunty";
                else if (age < 40)
                    prefix = "Ms.";

            if(prefix == "undefined")
                Console.WriteLine("Undefined gender {0} or age {1}", gender, age);
            else
                Console.WriteLine("Good Morning {0} {1}", prefix, name);
        }
    }
}