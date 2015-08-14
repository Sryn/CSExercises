using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex21_Test
    {
        [TestMethod]
        public void Ex21_TestWith88()
        {
            TestHelper t = new TestHelper();
            Random r = new Random();
            t.SetupConsole(new string[] { r.Next(1, 100).ToString(), r.Next(1, 100).ToString(), r.Next(1, 100).ToString(), "88" });
            TestHelper.RunMain(typeof(Ex21));
            t.AssertOutputContains("Lucky");
        }

        [TestMethod]
        public void Ex21_TestNo88()
        {
            TestHelper t = new TestHelper();
            Random r = new Random();
            t.SetupConsole(new string[] { r.Next(1, 100).ToString(), r.Next(1, 100).ToString(), r.Next(1, 100).ToString(), "87" });
            bool completed = TestHelper.ExecuteMain(typeof(Ex21),100);
            Assert.IsFalse(completed,"The program is not supposed to complete, but it is.");
            t.WriteLog();
        }

    }
}