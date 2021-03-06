using System;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex27 - This programe will calculate y=2(x^2)-4x+3 for the integer values of x between-5 and +5 inclusive.\n");
            int i, x, xStart, xEnd;
            xStart = -5;
            xEnd = +5;

            /**/
            // Code for the Ex27a part
            Console.WriteLine("X\tY");
            for (i = 1; i < 54; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine('-');

            for (x = xStart; x <= xEnd; x++ )
            {
                Console.WriteLine("{0:0.0}\t{1:0.0}", x*1.0, 1.0*((2 * x * x) - (4 * x) + 3));
            }
            /**/

            /*
            // Code for the Ex27b part - horizontal stars
            for(x=xStart; x<=xEnd; x++)
            {
                Console.Write("{0}\t", x);
                for(i=0; i<=((2 * x * x) - (4 * x) + 3); i++)
                {
                    Console.Write('*');
                }
                Console.Write('\n');
            }
            */

            /*
            // Code for the Ex27b part - vertical stars
            //
            // Do the stars here
            for (i = 75; i > 0; i-- )
            {
                // Label the y-axis here
                Console.Write("{0}\t", i);

                for(x=xStart; x<=xEnd; x++)
                {
                    if (i <= ((2 * x * x) - (4 * x) + 3))
                    {
                        Console.Write('*');
                    }
                    else
                        Console.Write(' ');
                }
                Console.Write('\n');
            }

            // Label the x-axis here
            Console.Write("\n\t");
            for (x = xStart; x <= xEnd; x++)
            {
                if (x < 0)
                {
                    Console.Write('-');
                }
                else if (x > 0)
                {
                    Console.Write('+');
                }
                else
                    Console.Write(' ');
            }
            Console.Write("\n\t");
            for (x = xStart; x <= xEnd; x++)
            {
                if (x < 0)
                {
                    Console.Write(-1*x);
                }
                else
                {
                    Console.Write(x);
                }
            }
            Console.Write('\n');
            */
        }
    }
}
