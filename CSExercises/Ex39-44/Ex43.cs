using System;

namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex43 - Program to use own SquareRoot module to printout the squareroots of the integers 1-25:");

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(Hex(i));
            }
        }

        public static string Hex(int i)
        {
            int intBefore = i / 16;
            int intAfter = i % 16;
            string strBefore;

            if (intBefore > 9)
                strBefore = Hex(intBefore);
            else if (intBefore == 0)
                strBefore = "";
            else
                strBefore = Convert.ToString(intBefore);

            switch (intAfter)
            {
                case  0:
                case  1:
                case  2:
                case  3:
                case  4:
                case  5:
                case  6:
                case  7:
                case  8:
                case  9: return strBefore.Insert(strBefore.Length, Convert.ToString(intAfter)); break;
                case 10: return strBefore.Insert(strBefore.Length, "A"); break;
                case 11: return strBefore.Insert(strBefore.Length, "B"); break;
                case 12: return strBefore.Insert(strBefore.Length, "C"); break;
                case 13: return strBefore.Insert(strBefore.Length, "D"); break;
                case 14: return strBefore.Insert(strBefore.Length, "E"); break;
                case 15: return strBefore.Insert(strBefore.Length, "F"); break;
                default:
                    return "Error"; break;
            } // switch (intAfter)

        }
    }
}
