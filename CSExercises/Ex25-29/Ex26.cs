using System;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex26 - This program will output the Inverse, Square Root and Square for the numbers 1 - 10 inclusive.");
            Console.WriteLine(" No\tInverse\t\tSquare Root\tSquare");
            int i;
            for (i = 1; i < 54; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine('-');

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0:0.0}\t{1:0.0##}\t\t{2:0.0##}\t\t{3:0.0}", i * 1.0, 1 / (i * 1.0), Math.Sqrt(Convert.ToDouble(i)), i * i * 1.0);
            }
        }
    }
}
