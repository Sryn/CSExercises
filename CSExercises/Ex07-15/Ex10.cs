using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.Write("Ex10 - Please type the (x,y) coordinates of two points and we'll calculate the distance between those two coordinates\nx1: ");
            double x1dbl = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1: ");
            double y1dbl = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2: ");
            double x2dbl = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2: ");
            double y2dbl = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(((x2dbl - x1dbl) * (x2dbl - x1dbl)) + ((y2dbl - y1dbl) * (y2dbl - y1dbl))));
        }
    }
}
