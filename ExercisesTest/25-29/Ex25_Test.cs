using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex25_Test
    {
        [TestMethod]
        public void Ex25_TestSimpleNumber()
        {
            TestHelper.TestOutputContains(typeof(Ex25), "5\r\n", "120");
        }

        [TestMethod]
        public void Ex25_TestBiggerNumber()
        {
            TestHelper.TestOutputContains(typeof(Ex25), "6\r\n", "720");
        }
    }
}