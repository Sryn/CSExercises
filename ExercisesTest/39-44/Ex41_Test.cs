using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex41_Test
    {
        [TestMethod]
        public void Ex41_TestOneChar()
        {
            bool found = Ex41.InString("The brown fox", "o");
            Debug.WriteLine("The brown fox, o");
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Ex41_TestPositive1()
        {
            bool found = Ex41.InString("The brown fox", "FOX");
            Debug.WriteLine("The brown fox, FOX");
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Ex41_TestPositive2()
        {
            bool found = Ex41.InString("The brown fox", "bRO");
            Debug.WriteLine("The brown fox, bRO");
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void Ex41_TestNegative1()
        {
            bool found = Ex41.InString("T", "bRO");
            Debug.WriteLine("T, FOX");
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void Ex41_TestNegative2()
        {
            bool found = Ex41.InString("The bras basah complex", "bRO");
            Debug.WriteLine("The bras basah complex, bRO");
            Assert.IsFalse(found);
        }
    }
}