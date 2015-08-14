using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex19_Test
    {
        [TestMethod]
        public void Ex19_TestWithZero()
        {
            TestHelper.TestOutputEqual(typeof(Ex19), "0\r\n", "2.4");
        }

        [TestMethod]
        public void Ex19_TestWithHalf()
        {
            TestHelper.TestOutputEqual(typeof(Ex19), "0.5\r\n", "2.4");
        }

        [TestMethod]
        public void Ex19_TestMidDistance()
        {
            Random r = new Random();
            double distance = 0.5 + r.Next(1, 85)/10.0;
            TestHelper.TestOutputEqual(typeof(Ex19), (distance-0.05) + "\r\n", (2.4 + (distance-0.5)*10*0.04).ToString());
        }

        [TestMethod]
        public void Ex19_Test9Km()
        {
            TestHelper.TestOutputEqual(typeof(Ex19), "9\r\n", (2.4 + 85 * 0.04).ToString());
        }

        [TestMethod]
        public void Ex19_Test1213Km()
        {
            TestHelper.TestOutputEqual(typeof(Ex19), "12.13\r\n", (7.4).ToString());
        }
    }
}