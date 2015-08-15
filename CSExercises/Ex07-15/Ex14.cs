using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.Write("Ex14 - Please type the lengths of the three sides of a Triangle and we'll calculate its area using Heron's Formula\nSide A: ");
            double dblSideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side B: ");
            double dblSideB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side C: ");
            double dblSideC = Convert.ToDouble(Console.ReadLine());
            double dblHalfPerimeter = (dblSideA + dblSideB + dblSideC) / 2;
            double Area = Math.Sqrt(dblHalfPerimeter * (dblHalfPerimeter - dblSideA) * (dblHalfPerimeter - dblSideB) * (dblHalfPerimeter - dblSideC));
            // This formula here will output NaN if the three given sides does not make a 'valid' Triangle
            // An easy way to check whether the given sides makes a valid triangle is to make sure that dblHalfPerimeter is at least of equal length to each of the sides
            if ((dblHalfPerimeter < dblSideA) || (dblHalfPerimeter < dblSideB) || (dblHalfPerimeter < dblSideC))
                Console.WriteLine("Given sides do not make a valid triangle");
            else
                Console.WriteLine(Area);
        }
    }
}