using System;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.Write("Ex19 - Please type a taxi distance travelled in km and we'll calculate the fare for you: ");
            double dblDistance = Convert.ToDouble(Console.ReadLine());
            dblDistance = Math.Ceiling(dblDistance * 10); // to round up to the next 100 meters
            double fare = 0.0;

            if(dblDistance < 0.0)
                Console.WriteLine("Illegal distance entered.");
            else if (dblDistance <= 5.0) // 0.5 km
                Console.WriteLine("{0}", 2.4);
            else if(dblDistance <= 90.0) // 9.0 km
            {
                fare = 2.4 + (dblDistance - 5) * 0.04;
                Console.WriteLine("{0}", fare);
            }
            else if(dblDistance > 90.0)
            {
                double dblTempDistance = dblDistance;

                // first 0.5 km
                dblTempDistance = dblTempDistance - 5.0;
                fare = 2.4;

                // next 8.5 km
                dblTempDistance = dblTempDistance - 85.0;
                fare = fare + (85 * 0.04);

                // then $0.05 for every leftover 100 meters
                fare = fare + (dblTempDistance * 0.05);

                Console.WriteLine("{0}", fare);
            }

        }
    }
}