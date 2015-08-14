using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex34_Test
    {
        [TestMethod]
        public void Ex34_TestForSomeOfTheResult()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("");
            TestHelper.RunMain(typeof (Ex34));
            t.WriteLog();
            Assert.AreEqual(1, t.CountOutputContaining("230"));
            Assert.AreEqual(1, t.CountOutputContaining("213"));
            Assert.AreEqual(1, t.CountOutputContaining("48"));
            Assert.AreEqual(2, t.CountOutputContaining("227"));
        }
    }
}