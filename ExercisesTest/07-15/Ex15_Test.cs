using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex15_Test
    {
        [TestMethod]
        public void Ex15_TestWithAmstrongNumber()
        {
            TestHelper.TestOutputEqual(typeof(Ex15), "153\r\n", "Armstrong Number");
        }

        [TestMethod]
        public void Ex15_TestWithRandomPositiveNumber()
        {
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                int n = r.Next(100, 999);
                if (n == 153 || n == 370 || n == 371 || n == 407)
                {
                    n = n + 1;
                }
                TestHelper.TestOutputEqual(typeof(Ex15), n + "\r\n", "Not Armstrong Number");
            }
        }

    }
}