using System;
using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex32_Test
    {
        [TestMethod]
        public void Ex32_TestForTheOnlyTestCase()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[]
            {
                "1000",
                "2000",
                "3000",
                "4000",
                "5000",
                "6000",
                "7000",
                "8000",
                "9000",
                "10000",
                "11000",
                "12000"
            });
            TestHelper.RunMain(typeof (Ex32));
            t.AssertOutputContains(1, "6500", true);
            t.AssertOutputContains(2, "0", false);
            t.AssertOutputContains(3, "11", false);
        }
    }
}