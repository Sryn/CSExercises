using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex29_Test
    {
        [TestMethod]
        public void Ex29_Test496()
        {
            TestHelper.TestOutputContains(typeof(Ex29), "496\r\n", "Perfect Number");
        }

        [TestMethod]
        public void Ex28_Test240()
        {
            TestHelper.TestOutputContains(typeof(Ex29), "240\r\n", "Not Perfect Number");
        }
    }
}