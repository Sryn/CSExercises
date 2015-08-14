using System;
using System.CodeDom;
using System.Diagnostics;
using System.IO;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex01Test
    {
        [TestMethod]
        public void Ex01_TestWithName1()
        {
            TestHelper help = new TestHelper();
            help.SetupConsole(new string[] {"John"});
            Ex01.Main(null);
            help.AssertOutput("Good Morning John");
        }

        [TestMethod]
        public void Ex01_TestWithName2()
        {
            TestHelper.TestOutputEqual(typeof(Ex01),"Jane Doe\r\n", "Good Morning Jane Doe");
        }

        [TestMethod]
        public void Ex01_TestWithEmptyString()
        {
            TestHelper.TestOutputEqual(typeof(Ex01),"\r\n", "Good Morning");
        }



    }
}
