using System;
using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex33_Test
    {
        [TestMethod]
        public void Ex33_TestForTheOrder()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("");
            TestHelper.RunMain(typeof (Ex33));
            t.WriteLog();
            String lastLine = t.GetOutputFromLast(1);
            string[] parts = lastLine.Split(new char[] {' ', '\t'});

            Debug.WriteLine(lastLine);
            Assert.AreEqual("93", parts[0]);
            Assert.AreEqual("89", parts[1]);
            Assert.AreEqual("3", parts[19]);
        }
    }
}