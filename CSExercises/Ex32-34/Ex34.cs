using System;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex34 - This program will, from a 2-dimensional array of marks for four subjects to 12 students: ");
            Console.WriteLine("a) Computer the total marks obtained by each student");
            Console.WriteLine("b) Compute the class average and standard deviation of Marks for each subject");
            Console.WriteLine("c) Determine the overall average of marks for the whole class for all subjects put together\n");

            // hard-code the marks
            int[,] intArr2DStudentMarks = new int[,] {
                {56,84,68,29},
                {94,73,31,89},
                {41,63,36,90},
                {99, 9,18,17},
                {62, 3,65,75},
                {40,96,53,23},
                {81,15,27,30},
                {21,70,100,22},
                {88,50,13,12},
                {48,54,52,78},
                {64,71,67,25},
                {16,93,46,72}
            };

            int[] intArrSubjectTotal = new int[] {0,0,0,0}; // 1D Array to keep Subject Total
            double[] intArrSubjectStdDev = new double[] { 0, 0, 0, 0 }; // 1D Array to keep Subject Standard Deviation
            int i, j, intEachStudentTotalMarks, intAllStudentsTotalMarks = 0;
            double dblAllStudentMarksAverage, dblStep01, dblStep02, dblStep03, dblStep04;

            // do part a)
            for (i = 0; i < intArr2DStudentMarks.GetLength(0); i++)
            {
                intEachStudentTotalMarks = 0;

                for (j = 0; j < intArr2DStudentMarks.GetLength(1); j++)
                {
                    intArrSubjectTotal[j] = intArrSubjectTotal[j] + intArr2DStudentMarks[i, j]; // for part b) and c)

                    intEachStudentTotalMarks = intEachStudentTotalMarks + intArr2DStudentMarks[i, j];
//                    Console.Write("{0}\t", intArr2DStudentMarks[i, j]);
                }

                intAllStudentsTotalMarks = intAllStudentsTotalMarks + intEachStudentTotalMarks; // for part b)

                Console.WriteLine("{0}", intEachStudentTotalMarks);
            } // for - end for part a)

            dblAllStudentMarksAverage = (1.0 * intAllStudentsTotalMarks) / (intArr2DStudentMarks.GetLength(0) * intArr2DStudentMarks.GetLength(1)); // for part c)

            // part b)
            // Standard Deviation is sqrt of Variance
            // Variance = {[SUM OF (Xi-M)^2]/N}; i=1 to N
            // N is number of data elements (Xi) and
            // M is mean (average)
            // dblStep01 -> Xi-M
            // dblStep02 -> (Xi-M)^2
            // dblStep03 -> Sum of (Xi-M)^2
            // dblStep04 -> [Sum of (Xi-M)^2]/N

            Console.WriteLine();

            for (j = 0; j < intArr2DStudentMarks.GetLength(1); j++)
            {
                dblStep03 = 0.0;

                for (i = 0; i < intArr2DStudentMarks.GetLength(0); i++)
                {
                    dblStep01 = (1.0 * intArr2DStudentMarks[i, j]) - (1.0 * intArrSubjectTotal[j]) / intArr2DStudentMarks.GetLength(0);
                    dblStep02 = dblStep01 * dblStep01;
                    dblStep03 = dblStep03 + dblStep02;
                }

                dblStep04 = dblStep03 / intArr2DStudentMarks.GetLength(0);
                intArrSubjectStdDev[j] = Math.Sqrt(dblStep04);
                Console.WriteLine("{0:0.00}\t{1:0.00}", (1.0 * intArrSubjectTotal[j]) / intArr2DStudentMarks.GetLength(0), intArrSubjectStdDev[j]);
            }
            // end part b)

            // part c)
            Console.WriteLine();
//            for (i = 0; i < intArr2DStudentMarks.GetLength(1); i++ )
//                Console.Write("{0:0.00}\t", (1.0 * intArrSubjectTotal[i]) / intArr2DStudentMarks.GetLength(0));
            Console.WriteLine(dblAllStudentMarksAverage);
            // end part c)

        }
    }
}
