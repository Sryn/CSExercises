using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex11 - Please type a taxi distance travelled in km and we'll calculate the fare for you using the formula $2.40 + $0.40 * Distance in km, rounded-up to the nearest $0.10: ");
            double dblDistance = Convert.ToDouble(Console.ReadLine());
            double dblFare = Math.Ceiling(10 * (2.4 + (0.4 * dblDistance))); // ceiling multiply by 10 to round up to the nearest 0.10
            Console.WriteLine("{0:0.00}", dblFare/10); // divide by 10 to move the decimal point back 1 step to left                       
        }
    }
}
