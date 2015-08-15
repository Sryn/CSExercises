using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex11 - Please type a taxi distance travelled in km and we'll calculate the fare for you using the formula $2.40 + $0.40 * Distance in km: ");
            double dblDistance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(2.4 + (0.4 * dblDistance));
        }
    }
}
