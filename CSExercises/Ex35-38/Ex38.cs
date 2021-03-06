using System;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex38 - This program will, from two 1D arrays of Student_Name and Marks, print\na. a report sorted in descending order of Marks\nb. a report sorted on student names alphabetically.\n");

            string[] strArrName = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] intArrMark = new int[] { 63, 29, 75, 82, 55 };
//            string[] strArrName = new string[] { "John", "Venkat", "Mary", "Victor", "Betty", "Robinson", "Robin" };
//            int[] intArrMark = new int[] { 63, 29, 75, 82, 55, 63, 75 }; // these two arrays were used to test my code whether they could manage same marks [yes] and similar names [no]
            int i, j;

            // Report a.
            int[] intArrMarkIdx = new int[] { 0, 1, 2, 3, 4 }; // need this to refer to descending order
//            int[] intArrMarkIdx = new int[] { 0, 1, 2, 3, 4, 5, 6 }; // need this to refer to descending order
            int[] intArrDescMark = new int[intArrMark.Length]; // need this to actually order. Previous code without this was awry!

            for (i = 0; i < intArrMark.Length; i++)
                intArrDescMark[i] = intArrMark[i];

            int intTemp;
//            int intHighestMarkIdx;

            // interatively find the largest mark downwards and arrange intArrDescMark[] as well as update intArrMarkIdx[]
            for (i = 0; i < intArrDescMark.Length-1; i++)
            {
                for (j = i + 1; j < intArrDescMark.Length; j++)
                {
                    if (intArrDescMark[j] > intArrDescMark[i])
                    {
                        intTemp = intArrDescMark[i];
                        intArrDescMark[i] = intArrDescMark[j];
                        intArrDescMark[j] = intTemp;

                        intTemp = intArrMarkIdx[i];
                        intArrMarkIdx[i] = intArrMarkIdx[j];
                        intArrMarkIdx[j] = intTemp;
                    }
                }
            }

            // print the descending table by mark
            for (i = 0; i < intArrMark.Length; i++)
            {
                Console.Write("{0}\t{1}\n", strArrName[intArrMarkIdx[i]], intArrMark[intArrMarkIdx[i]]);
            }
            // end Report a.


            // Report b.
//            Console.WriteLine("B > A ? {0}", 'B' > 'A'); // true
//            Console.WriteLine("A > B ? {0}", 'A' > 'B'); // false
            int[] intArrNameIdx = new int[] { 0, 1, 2, 3, 4 }; // need this to refer to descending order
//            int[] intArrNameIdx = new int[] { 0, 1, 2, 3, 4, 5, 6 }; // need this to refer to descending order
            string[] strArrAscName = new string[strArrName.Length]; // need this to actually order.
            int k;
//            int l;
            Boolean notSwapped;
            string strTempName;
            char chrI = ' ', chrJ = ' ';

            for (i = 0; i < strArrName.Length; i++)
                strArrAscName[i] = strArrName[i];

            // interatively find the 'smallest' name upwards and arrange strArrAscName[] as well as update intArrNameIdx[]
            for (i = 0; i < strArrAscName.Length - 1; i++)
            {
                for (j = i + 1; j < strArrAscName.Length; j++)
                {
                    if (strArrAscName[i] != strArrAscName[j]) // don't swap if both names are the same
                    {
                        k = 0;
                        notSwapped = true;

                        if (k > strArrAscName[i].Length && k > strArrAscName[j].Length)
                        {
                            chrI = Convert.ToChar(strArrAscName[i].Substring(k, 1));
                            chrJ = Convert.ToChar(strArrAscName[j].Substring(k, 1));
                        }
                        else
                            notSwapped = false;

                        while (notSwapped)
                        {
//                            Console.WriteLine("chrI={0} chrJ={1}", chrI, chrJ);
                            if (chrI > chrJ)
                            {
                                strTempName = strArrAscName[i];
                                strArrAscName[i] = strArrAscName[j];
                                strArrAscName[j] = strTempName;

                                intTemp = intArrNameIdx[i];
                                intArrNameIdx[i] = intArrNameIdx[j];
                                intArrNameIdx[j] = intTemp;

                                notSwapped = false;
                                /*
                                Console.WriteLine();
                                for (l = 0; l < strArrAscName.Length; l++)
                                    Console.WriteLine(strArrAscName[l]);
                                */
                            }
                            else if (chrJ > chrI)
                                notSwapped = false;
                                
                            k++;
                        }
                    }
                }
            }

            // print the ascending table by name
            Console.WriteLine();
            for (i = 0; i < strArrName.Length; i++)
            {
                Console.Write("{0}\t{1}\n", strArrName[intArrNameIdx[i]], intArrMark[intArrNameIdx[i]]);
            }
            // end Report b.

        }
    }
}
