using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.Write("Ex04 - Please type a double: ");
            double aDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The squareroot of the double {0} is {1}", aDouble, Math.Sqrt(aDouble));
        }
    }
}
