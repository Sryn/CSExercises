using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex44_Test
    {
        [TestMethod]
        public void Ex44_TestNoSubstitution()
        {
            Debug.WriteLine("Bad dog, e, o => Bad dog");
            Assert.AreEqual("Bad dog", Ex44.Substitute("Bad dog",'e','o'));
        }

        [TestMethod]
        public void Ex44_TestMultipleSubstitution()
        {
            Debug.WriteLine("Bad dog, d, f => Baf fog");
            Assert.AreEqual("Baf fog", Ex44.Substitute("Bad dog", 'd', 'f'));
        }
    
    }
}