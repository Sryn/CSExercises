using System.Threading;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex24_Test
    {
        [TestMethod]
        public void Ex24_TestSimpleNumber()
        {
            TestHelper.TestOutputContains(typeof(Ex24), "16\r\n", "4.00000");
        }

        [TestMethod]
        public void Ex24_TestBiggerNumber()
        {
            TestHelper.TestOutputContains(typeof(Ex24), "243\r\n", "15.5884");
        }
    }
}