using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex22_Test
    {
        [TestMethod]
        public void Ex22_TestWithPositiveNumber1()
        {
            TestHelper t = new TestHelper();
            Random r = new Random();
            t.SetupConsole(new string[] { "8", "4" });
            TestHelper.RunMain(typeof(Ex22));
            t.AssertOutputContains(2,"4",true);
            t.AssertOutputContains(1,"8",false);
        }

        [TestMethod]
        public void Ex22_TestWithPositiveNumber2()
        {
            TestHelper t = new TestHelper();
            Random r = new Random();
            t.SetupConsole(new string[] { "2000", "120" });
            TestHelper.RunMain(typeof(Ex22));
            t.AssertOutputContains(2, "80", true);
            t.AssertOutputContains(1, "3000", false);
        }

    }
}