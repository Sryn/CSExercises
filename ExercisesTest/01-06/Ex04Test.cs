using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex04Test
    {
        [TestMethod]
        public void Ex04_TestWithZero()
        {
            TestHelper.TestOutputEqual(typeof(Ex04), "0\r\n", "0");
        }

        [TestMethod]
        public void Ex04_TestWithRandomNumber()
        {
            Random r = new Random();
            double n = Math.Round(r.NextDouble()*100,5);
            TestHelper.TestOutputEqual(typeof(Ex04), n + "\r\n", Math.Sqrt(n).ToString());
        }

    }
}
