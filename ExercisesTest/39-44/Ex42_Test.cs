using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex42_Test
    {
        [TestMethod]
        public void Ex42_TestOneChar()
        {
            int index = Ex42.FindWord("The brown fox", "o");
            Debug.WriteLine("The brown fox, o => should return 6");
            Assert.AreEqual(6, index);
        }

        [TestMethod]
        public void Ex42_TestPositive1()
        {
            int index = Ex42.FindWord("The brown fox", "FOX");
            Debug.WriteLine("The brown fox, FOX => should return 10");
            Assert.AreEqual(10, index);
        }

        [TestMethod]
        public void Ex42_TestPositive2()
        {
            int index = Ex42.FindWord("The brown fox", "bRO");
            Debug.WriteLine("The brown fox, bRO => should return 4");
            Assert.AreEqual(4, index);
        }

        [TestMethod]
        public void Ex42_TestNegative1()
        {
            int index = Ex42.FindWord("T", "bRO");
            Debug.WriteLine("T, FOX => should return -1");
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void Ex42_TestNegative2()
        {
            int index = Ex42.FindWord("The bras basah complex", "bRO");
            Debug.WriteLine("The bras basah complex, bRO => should return -1");
            Assert.AreEqual(-1, index);
        }
    }
}