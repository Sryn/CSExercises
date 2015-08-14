using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex17_Test
    {
        [TestMethod]
        public void Ex17_TestWithUncle()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "Arnold", "M", "40"});
            TestHelper.RunMain(typeof(Ex17));
            t.AssertOutput("Good Morning Uncle Arnold".ToString());
        }

        [TestMethod]
        public void Ex17_TestWithAunty()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "Madonna", "F", "51" });
            TestHelper.RunMain(typeof (Ex17));
            t.AssertOutput("Good Morning Aunty Madonna".ToString());
        }

        [TestMethod]
        public void Ex17_TestWitMr()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "Will Smith", "M" });
            TestHelper.RunMain(typeof(Ex17));
            t.AssertOutput("Good Morning Mr. Will Smith".ToString());
        }

        [TestMethod]
        public void Ex17_TestWithMs()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "Ariana Grande", "F", "18" });
            TestHelper.RunMain(typeof(Ex17));
            t.AssertOutput("Good Morning Ms. Ariana Grande".ToString());
        }

        [TestMethod]
        public void Ex17_TestWithUnknown()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "Jane Austen", "X", "20" });
            TestHelper.RunMain(typeof(Ex17));
            t.AssertOutputNotContaining("Jane Austen");
        }
    }
}