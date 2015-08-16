using System;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.Write("Ex18 - Please type in your mark (0-100) and we'll show you your grade: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            if ((mark < 0) || (mark > 100))
                Console.WriteLine("**Error**");
            else if (mark < 40)
                Console.WriteLine("You scored {0} marks which is F grade.", mark);
            else if (mark < 60)
                Console.WriteLine("You scored {0} marks which is C grade.", mark);
            else if (mark < 80)
                Console.WriteLine("You scored {0} marks which is B grade.", mark);
            else
                Console.WriteLine("You scored {0} marks which is A grade.", mark);
        }
    }
}