using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex09 - Please type a value for x and we'll calculate y=2(x^2)-4x+3:");
            double aDoubleX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:0.#}", (2 * aDoubleX * aDoubleX) - (4 * aDoubleX) + 3);
        }
    }
}
