﻿using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex10Test
    {
        [TestMethod]
        public void Ex10_TestWithZero()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "0", "0", "0", "0" });
            TestHelper.RunMain(typeof(Ex10));
            t.AssertOutput(0.ToString());
        }

        [TestMethod]
        public void Ex10_TestWithPositiveNumber()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "20","0","20","20"});
            TestHelper.RunMain(typeof (Ex10));
            t.AssertOutput(20.ToString());
        }

        [TestMethod]
        public void Ex10_TestWithNegativeNumber()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "20", "0", "-20", "-20" });
            TestHelper.RunMain(typeof(Ex10));
            t.AssertOutput(Math.Sqrt(40*40+20*20).ToString());
        }

    }
}