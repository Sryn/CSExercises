using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex02 - Please type an integer we'll give you it's square: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(A * A);
        }
    }
}
