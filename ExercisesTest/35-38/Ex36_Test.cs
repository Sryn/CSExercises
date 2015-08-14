using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex36_Test
    {
        [TestMethod]
        public void Ex36_TestWithMadam()
        {
            TestHelper.TestOutputEqual(typeof(Ex36),"madam","Palindrome");
        }

        [TestMethod]
        public void Ex36_TestWithSanta()
        {
            TestHelper.TestOutputEqual(typeof(Ex36), "A Santa at NASA", "Palindrome");
        }

        [TestMethod]
        public void Ex36_TestWithISS()
        {
            TestHelper.TestOutputEqual(typeof(Ex36), "Institute of Systems Science", "Not Palindrome");
        }

    }
}