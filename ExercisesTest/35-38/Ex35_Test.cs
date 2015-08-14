using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex35_Test
    {
        [TestMethod]
        public void Ex35_TestWithABCDE()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("Abcde");
            TestHelper.RunMain(typeof(Ex35));
            t.WriteLog();
            Assert.AreEqual(1, t.CountOutputContaining("2"));
            Assert.AreEqual(2, t.CountOutputContaining("1"));
            Assert.AreEqual(3, t.CountOutputContaining("0"));

        }

        [TestMethod]
        public void Ex35_TestWithRycky()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("rykcy");
            TestHelper.RunMain(typeof(Ex35));
            t.WriteLog();
            Assert.AreEqual(6, t.CountOutputContaining("0"));
        }

        [TestMethod]
        public void Ex35_TestWithAeiou()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("AEIOUaeiou");
            TestHelper.RunMain(typeof(Ex35));
            t.WriteLog();
            Assert.AreEqual(1, t.CountOutputContaining("10"));
            Assert.AreEqual(5, t.CountOutputContaining("2"));
        }

    }
}