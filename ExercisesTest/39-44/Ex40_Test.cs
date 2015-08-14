using System;
using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex40_Test
    {
        [TestMethod]
        public void Ex40_Test25()
        {
            double result = Ex40.SQT(25);
            Debug.WriteLine("SQT(25) => 5");
            Assert.AreEqual(5.0,result,0.00001);
        }

        [TestMethod]
        public void Ex40_Test36()
        {
            double result = Ex40.SQT(36);
            Debug.WriteLine("SQT(36) => 6");
            Assert.AreEqual(6.0, result, 0.00001);
        }

        [TestMethod]
        public void Ex40_TestRandomPositive()
        {
            Random r= new Random();
            int input = r.Next(1, 100);
            double result = Ex40.SQT(input);
            Debug.WriteLine("SQT({0}) => {1}", input, Math.Sqrt(input));
            Assert.AreEqual(Math.Sqrt(input), result, 0.00001);
        }

    }
}