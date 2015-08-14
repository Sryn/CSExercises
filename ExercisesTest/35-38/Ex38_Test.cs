using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex38_Test
    {
        [TestMethod]
        public void Ex38_TestOrder()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("");
            TestHelper.RunMain(typeof (Ex38));
            t.AssertOutputContains(1, "Victor", true);
            t.AssertOutputContains(2, "Venkat", false);
            t.AssertOutputContains(3, "Mary", false);
            t.AssertOutputContains(4, "John", false);
        }
    }
}