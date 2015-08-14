using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.Write("Ex05 - Please type a double: ");
            double aDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The squareroot, rounded to three decimal places, of the double {0} is {1:0.000}", aDouble, Math.Sqrt(aDouble));
        }
    }
}
