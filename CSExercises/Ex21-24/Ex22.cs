using System;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex22 - Finding HCF and LCM from two Integers using Euclid's Algorithm");
            int intA, intB;
//            int intCounter = 1;
            double dblLower, dblHigher, dblTemp;
            Console.Write("Enter A: ");
            intA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            intB = Convert.ToInt32(Console.ReadLine());

            if(intA == intB)
            {
                // if both A and B starts out the same value, then their respective HCF and LCM are the same value as them
                Console.WriteLine("HCF: {0}\nLCM: {1}", intA, intB); 
            }
            else
            {
                if(intA < intB)
                {
                    dblLower = intA;
                    dblHigher = intB;
                }
                else
                {
                    dblLower = intB;
                    dblHigher = intA;
                }

                while(dblLower != dblHigher)
                {
//                    Console.WriteLine("Counter = {0}\tLower = {1}\tHigher = {2}", intCounter++, dblLower, dblHigher);
                    dblHigher = dblHigher - dblLower;
                    if(dblHigher < dblLower)
                    {
                        dblTemp = dblHigher;
                        dblHigher = dblLower;
                        dblLower = dblTemp;
                    }
                }
//                Console.WriteLine("Counter = {0}\tLower = {1}\tHigher = {2}", intCounter++, dblLower, dblHigher);

                Console.WriteLine("HCF: {0}\nLCM: {1}", dblHigher, (intA * intB)/dblLower);
            }
        }
    }
}
