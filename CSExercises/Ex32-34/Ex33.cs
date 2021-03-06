using System;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex33 - This program will use simple selection sort to do a decreasing sort on 20 hard-coded integers and print out the array at every pass.");

            int[] intArr20Numbers = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            int i=0, j=0, k, temp;

            // get a number one at a time from the left-most number
            do
            {
                j = i + 1; // initialises the compared number to start one number to the right of the current number

                // compares
                do
                {
                    // descending order swap
                    if (intArr20Numbers[j] > intArr20Numbers[i])
                    {
                        temp = intArr20Numbers[i];
                        intArr20Numbers[i] = intArr20Numbers[j];
                        intArr20Numbers[j] = temp;
                    }

                    j++; // to get the number to the right

                } while (j < intArr20Numbers.Length); // compares until the last right-most number

                i++;

            } while (i < intArr20Numbers.Length-1); // get the current number until the second last right-most number

            // print current progress
            for (k = 0; k < intArr20Numbers.Length; k++)
            {
                Console.Write("{0}\t", intArr20Numbers[k]);
            }

        }
    }
}
