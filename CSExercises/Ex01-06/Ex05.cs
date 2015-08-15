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
            Console.WriteLine("Ex05 - Please type a double and we'll give you it's squareroot, rounded to three decimal places: ");
            double aDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:0.###}", Math.Sqrt(aDouble));
        }
    }
}
