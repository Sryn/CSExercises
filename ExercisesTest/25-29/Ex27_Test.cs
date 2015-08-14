using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex27_Test
    {
        [TestMethod]
        public void Ex27_TestTheOnlyCase()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("");
            TestHelper.RunMain(typeof (Ex27));
            Assert.AreEqual(1, t.CountOutputContaining("73.0"));
            Assert.AreEqual(1, t.CountOutputContaining("51.0"));
        }
    }
}