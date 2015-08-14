using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex08Test
    {
        [TestMethod]
        public void Ex08_TestWithZero()
        {
            TestHelper.TestOutputEqual(typeof(Ex08), "0\r\n", 32.ToString());
        }

        [TestMethod]
        public void Ex08_TestWithRandomPositiveNumber()
        {
            Random r = new Random();
            double n = r.Next(1, 100);
            TestHelper.TestOutputEqual(typeof(Ex08), n + "\r\n", (n*1.8 + 32).ToString());
        }

        [TestMethod]
        public void Ex08_TestWithRandomNegativeNumber()
        {
            Random r = new Random();
            double n = r.Next(-100, -1);
            TestHelper.TestOutputEqual(typeof(Ex08), n + "\r\n", (n * 1.8 + 32).ToString());
        }

    }
}
