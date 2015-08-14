using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.Write("Please type a double: ");
            double aString = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The square of the double {0} is {1}", aString, aString * aString);
        }
    }
}
