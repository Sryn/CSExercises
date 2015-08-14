using System;
using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex43_Test
    {
        [TestMethod]
        public void Ex43_TestOneToOneHundred()
        {
            for (int i = 1; i <= 100; i++)
            {
                string expected = i.ToString("X");
                string output = Ex43.Hex(i);
                Debug.WriteLine("Hex of {0} should be {1}", i, expected);
                Assert.AreEqual(expected, output);
            }
        }
    }
}