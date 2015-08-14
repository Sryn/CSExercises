using System;
using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex39_Test
    {
        [TestMethod]
        public void Ex39_Test5()
        {
            long result = Ex39.Factorial(5);
            Debug.WriteLine("Factorial(5) => 120");
            Assert.AreEqual(120,result);
        }

        [TestMethod]
        public void Ex39_Test6()
        {
            long result = Ex39.Factorial(6);
            Debug.WriteLine("Factorial(6) => 720");
            Assert.AreEqual(720, result);
        }

    }
}