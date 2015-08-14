using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex14_Test
    {
        [TestMethod]
        public void Ex14_TestWithZero()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "0", "0", "0" });
            TestHelper.RunMain(typeof(Ex14));
            t.AssertOutput(0.ToString());
        }

        [TestMethod]
        public void Ex14_TestWithPositiveNumber()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "3","4","5"});
            TestHelper.RunMain(typeof (Ex14));
            t.AssertOutput(6.ToString());
        }

    }
}