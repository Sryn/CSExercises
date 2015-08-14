using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex20_Test
    {
        [TestMethod]
        public void Ex20_TestWithZero()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "0", "0", "0"});
            TestHelper.RunMain(typeof(Ex20));
            t.AssertOutputContains(0.ToString("c"));
        }

        [TestMethod]
        public void Ex20_TestWithOneProduct1()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "6", "0", "0" });
            TestHelper.RunMain(typeof (Ex20));
            t.AssertOutputContains((5400 * .9).ToString("c"));
        }

        [TestMethod]
        public void Ex20_TestWithOneProduct2()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "0", "10", "0" });
            TestHelper.RunMain(typeof(Ex20));
            t.AssertOutputContains((5000).ToString("c"));
        }

        [TestMethod]
        public void Ex20_TestWithOneProduct3()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "0", "11", "0" });
            TestHelper.RunMain(typeof(Ex20));
            t.AssertOutputContains((5500*.9).ToString("c"));
        }

        [TestMethod]
        public void Ex20_TestWithOneProduct4()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "0", "20", "0" });
            TestHelper.RunMain(typeof(Ex20));
            t.AssertOutputContains((10000 * .9).ToString("c"));
        }

        [TestMethod]
        public void Ex20_TestWithOneProduct5()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "0", "0", "8" });
            TestHelper.RunMain(typeof(Ex20));
            t.AssertOutputContains((5600).ToString("c"));
        }

        [TestMethod]
        public void Ex20_TestWithTwoProducts1()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "1", "20", "0" });
            TestHelper.RunMain(typeof(Ex20));
            t.AssertOutputContains((10900 * .85).ToString("c"));
        }

        [TestMethod]
        public void Ex20_TestWithThreeProducts1()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "1", "20", "3" });
            TestHelper.RunMain(typeof(Ex20));
            t.AssertOutputContains((10900 * .85 +2100).ToString("c"));
        }
    }
}