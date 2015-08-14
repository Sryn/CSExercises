using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex07Test
    {
        [TestMethod]
        public void Ex07_TestWithZero()
        {
            TestHelper.TestOutputEqual(typeof(Ex07), "0\r\n", String.Format("{0:c}",0));
        }

        [TestMethod]
        public void Ex07_TestWithRandomNumber()
        {
            Random r = new Random();
            double n = r.Next(1, 100);
            TestHelper.TestOutputEqual(typeof(Ex07), n + "\r\n", String.Format("{0:c}",n*1.13));
        }

    }
}
