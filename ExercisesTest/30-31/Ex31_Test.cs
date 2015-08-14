using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex31_Test
    {
        [TestMethod]
        public void Ex31_TestForTheOnlyTestCase()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("");
            TestHelper.RunMain(typeof(Ex31));
            t.AssertOutputContains(1, "496", true);
            t.AssertOutputContains(2, "28", false);
            t.AssertOutputContains(3, "6", false);
        }
    }
}