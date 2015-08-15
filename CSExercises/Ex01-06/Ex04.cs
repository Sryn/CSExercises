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
            Console.WriteLine("Ex04 - Please type a double and we'll give you it's squareroot: ");
            double aDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(aDouble));
        }
    }
}
