using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex09Test
    {
        [TestMethod]
        public void Ex09_TestWithZero()
        {
            TestHelper.TestOutputEqual(typeof(Ex09), "0\r\n", 3.ToString());
        }

        [TestMethod]
        public void Ex09_TestWithRandomPositiveNumber()
        {
            Random r = new Random();
            double n = r.Next(1, 100);
            TestHelper.TestOutputEqual(typeof(Ex09), n + "\r\n", (2 * n * n - 4 * n + 3).ToString());
        }

        [TestMethod]
        public void Ex09_TestWithRandomNegativeNumber()
        {
            Random r = new Random();
            double n = r.Next(-100, -1);
            TestHelper.TestOutputEqual(typeof(Ex09), n + "\r\n", (2 * n * n - 4 * n + 3).ToString());
        }

    }
}
