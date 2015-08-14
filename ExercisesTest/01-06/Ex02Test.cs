using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex02Test
    {
        [TestMethod]
        public void Ex02_TestWithZero()
        {
            TestHelper.TestOutputEqual(typeof(Ex02), "0\r\n", "0");
        }

        [TestMethod]
        public void Ex02_TestWithRandomNumber()
        {
            Random r = new Random();
            int n = r.Next(1, 100);
            TestHelper.TestOutputEqual(typeof(Ex02), n + "\r\n", (n * n).ToString());
        }

    }
}
