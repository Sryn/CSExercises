using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex08 - Please type a Centigrade temperature and we'll convert it to Fahrenheit:");
            double aCentigradeDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((1.8 * aCentigradeDouble) + 32);
        }
    }
}
