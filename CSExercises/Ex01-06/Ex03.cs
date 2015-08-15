using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex03 - Please type a double and we'll give you it's square: ");
            double aDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(aDouble * aDouble);
        }
    }
}
