using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex11 - Please type a taxi distance travelled in km and we'll calculate the fare for you using the formula $2.40 + $0.40 * Distance in km, rounded to the nearest $0.10: ");
            double dblDistance = Convert.ToDouble(Console.ReadLine());
            double dblFare = Math.Round(2.4 + (0.4 * dblDistance), 1);
            Console.WriteLine("{0:0.00}", dblFare);            
        }
    }
}
