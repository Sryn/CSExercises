using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex06 - Please type an integer and we'll give you it's squareroot, rounded to three decimal places: ");
            int anInteger = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("The squareroot of the integer {0} is {1}.", anInteger, Math.Sqrt(Convert.ToDouble(anInteger)));
            Console.WriteLine("{0:0.###}", Math.Sqrt(anInteger)); // same answer as above
        }
    }
}
