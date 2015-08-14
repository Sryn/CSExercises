using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex28_Test
    {
        [TestMethod]
        public void Ex28_Test241()
        {
            TestHelper.TestOutputContains(typeof(Ex28), "241\r\n", "Prime");
        }

        [TestMethod]
        public void Ex28_Test240()
        {
            TestHelper.TestOutputContains(typeof(Ex28), "240\r\n", "Not Prime");
        }
    }
}