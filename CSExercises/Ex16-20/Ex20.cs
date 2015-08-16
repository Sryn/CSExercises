using System;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.Write("Ex20 - Electrifying Electronics Pte Ltd.\nEnter quantity for TV: ");
            int intTV = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for DVD: ");
            int intDVD = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for MP3: ");
            int intMP3 = Convert.ToInt32(Console.ReadLine());

            double dblTVnDVD_SubTotal_Price = (intTV * 900) + (intDVD * 500);
            int intDiscount = 0;

            if (dblTVnDVD_SubTotal_Price > 10000)
            {
                intDiscount = 15;
//                Console.WriteLine("15% discount given.");
            }
            else if (dblTVnDVD_SubTotal_Price > 5000)
            {
                intDiscount = 10;
//                Console.WriteLine("10% discount given.");
            }
//            else
//                Console.WriteLine("No discount given.");
            
            if(intDiscount > 0)
            {
//                Console.WriteLine("Calculating discount at {0}%", intDiscount);
                dblTVnDVD_SubTotal_Price = dblTVnDVD_SubTotal_Price - (dblTVnDVD_SubTotal_Price * (intDiscount / 100.0));
//                Console.WriteLine("SubTotal = {0:c}", dblTVnDVD_SubTotal_Price);
            }

            double dblTotalPrice = dblTVnDVD_SubTotal_Price + (intMP3 * 700);

            Console.WriteLine("{0:c}", dblTotalPrice);
        }
    }
}