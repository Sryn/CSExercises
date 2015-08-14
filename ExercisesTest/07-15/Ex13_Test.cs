using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex13_Test
    {
        [TestMethod]
        public void Ex13_TestWithZero()
        {
            TestHelper.TestOutputEqual(typeof(Ex13), "0\r\n", (2.40).ToString(".00"));
        }

        [TestMethod]
        public void Ex13_TestWithRandomPositiveNumber()
        {
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                double n = r.Next(1, 100) + (r.Next(1, 3) * 0.01);
                TestHelper.TestOutputEqual(typeof(Ex13), n + "\r\n", (Math.Ceiling((2.4 + n * 0.4) * 10) / 10).ToString(".00"));
            }
        }

    }
}