using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex30_Test
    {
        [TestMethod]
        public void Ex30_TestForTheOnlyTestCase()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("");
            TestHelper.RunMain(typeof (Ex30));
            t.AssertOutputContains(1, "9973", true);
            t.AssertOutputContains(2, "9967", false);
            t.AssertOutputContains(3, "9949", false);
        }
    }
}