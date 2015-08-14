using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex45_Test
    {
        [TestMethod]
        public void Ex45_Test195()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("1.95");
            TestHelper.RunMain(typeof (Ex45));
            t.AssertOutputContains(1, "5c", true);
            t.AssertOutputContains(2, "20c", false);
            t.AssertOutputContains(3, "20c", false);
            t.AssertOutputContains(4, "50c", false);
            t.AssertOutputContains(5, "100c", false);
        }

        [TestMethod]
        public void Ex45_Test105()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("1.05");
            TestHelper.RunMain(typeof(Ex45));
            t.AssertOutputContains(1, "5c", true);
            t.AssertOutputContains(2, "100c", false);
        }
    
    }
}