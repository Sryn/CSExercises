using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex16_Test
    {
        [TestMethod]
        public void Ex16_TestWithMale()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "John Smith", "M"});
            TestHelper.RunMain(typeof(Ex16));
            t.AssertOutput("Good Morning Mr. John Smith".ToString());
        }

        [TestMethod]
        public void Ex16_TestWithFemale()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "Jane Austen","F"});
            TestHelper.RunMain(typeof (Ex16));
            t.AssertOutput("Good Morning Ms. Jane Austen".ToString());
        }

        [TestMethod]
        public void Ex16_TestWithUnknown()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "Jane Austen", "X" });
            TestHelper.RunMain(typeof(Ex16));
            t.AssertOutputNotContaining("Jane Austen");
        }
    }
}