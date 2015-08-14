using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex37_Test
    {
        [TestMethod]
        public void Ex37_TestWithEmptyString()
        {
            TestHelper.TestOutputEqual(typeof(Ex37),"\r\n","");
        }

        [TestMethod]
        public void Ex37_TestWithOneWord()
        {
            TestHelper.TestOutputContains(typeof(Ex37), "   ball ", "   Ball");
        }

        [TestMethod]
        public void Ex37_TestWithISS()
        {
            TestHelper.TestOutputContains(typeof(Ex37), "institute Of systems science", "Institute of Systems Science");
        }

    }
}