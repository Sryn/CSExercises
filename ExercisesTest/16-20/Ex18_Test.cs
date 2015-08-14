using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex18_Test
    {
        [TestMethod]
        public void Ex18_TestWithZero()
        {
            int grade = 0;
            TestHelper.TestOutputEqual(typeof(Ex18), grade+"\r\n", "You scored " +grade+" marks which is F grade.");
        }

        [TestMethod]
        public void Ex18_TestForA()
        {
            int grade = 80;
            TestHelper.TestOutputEqual(typeof(Ex18), grade + "\r\n", "You scored " + grade + " marks which is A grade.");
        }

        [TestMethod]
        public void Ex18_TestForB()
        {
            int grade = 60;
            TestHelper.TestOutputEqual(typeof(Ex18), grade + "\r\n", "You scored " + grade + " marks which is B grade.");
        }

        [TestMethod]
        public void Ex18_TestForC()
        {
            int grade = 40;
            TestHelper.TestOutputEqual(typeof(Ex18), grade + "\r\n", "You scored " + grade + " marks which is C grade.");
        }

        [TestMethod]
        public void Ex18_TestWithNegative()
        {
            TestHelper.TestOutputEqual(typeof(Ex18), "-40\r\n", "**Error**");
        }

        [TestMethod]
        public void Ex18_TestWithLargeNumber()
        {
            TestHelper.TestOutputEqual(typeof(Ex18), "400\r\n", "**Error**");
        }
    }
}