using System;
using NUnit.Framework;
using FS = SimplexMethod;

namespace TestSimplexMethod
{
    public class TestsSimplexMethod
    {
        [Test]
        public void SimplexMethodUniversalResult()
        {
            FS.VecB = new double [] { 200f, 1000f, 900f, 5000f };
            FS.MatrixA = new double [,] { { 1f, 0f, 1f, 2.5f }, { 0f, 1f, 1f, 6f } };
            FS.VecC = new double [] { 24, 24 };
            FS.Znak = new string [] { "<", "<", ">", "=" };
            var result = FS.StartProgram();

            //Проверка Z
            Assert.AreEqual((double)result [3], 21600, 1);
            //Проверка итоговых значений X
            Array.Sort((Int32 [])result [4]); //просто в начале нужно указать интересующие Х
            Int32 [] testRes = new [] { 0, 0, 1, 2 };
            Assert.AreEqual(result [4], testRes);
            var expected = (double [])result [1];
            var actual = new double [] { 85.66, 214.34, 114.34, 785.66 };
            for (int ex = 0; ex < expected.Length; ex++)
            {
                Assert.AreEqual(expected [ex], actual [ex], 1);
            }

            FS.VecB = new double [] { 800, 700, 500, 400, 1900, 10545 };
            FS.MatrixA = new double [,]
            {
                {1, 0, 0, 0, 1, 1.95},
                {0, 1, 0, 0, 1, 5.15},
                {0, 0, 1, 0, 1, 5},
                {0, 0, 0, 1, 1, 5.55}
            };
            FS.VecC = new double [] { 11.52, 71.07, 52.8, 59.25 };
            FS.Znak = new string [] { "<", "<", "<", "<", ">", "=" };
            result = FS.StartProgram();

            //Проверка Z
            Assert.AreEqual((double)result [3], 103305, 1);
            //Проверка итоговых значений X
            Array.Sort((Int32 [])result [4]); //просто в начале нужно указать интересующие Х
            testRes = new [] { 0, 0, 1, 2, 3, 4 };
            Assert.AreEqual(result [4], testRes);
            expected = (double [])result [1];
            actual = new double [] { 500, 700, 500, 400, 300, 1635 };
            for (int ex = 0; ex < expected.Length; ex++)
            {
                Assert.AreEqual(expected [ex], actual [ex], 1);
            }

            FS.VecB = new double [] { 800, 700, 500, 400, 1900, 10545 };
            FS.MatrixA = new double [,]
            {
                {1, 0, 0, 0, 1, 1.95},
                {0, 1, 0, 0, 1, 5.15},
                {0, 0, 1, 0, 1, 5},
                {0, 0, 0, 1, 1, 5.55}
            };
            FS.VecC = new double [] { 21.27, 71.07, 52.8, 59.25 };
            FS.Znak = new string [] { "<", "<", "<", "<", ">", "=" };
            result = FS.StartProgram();

            //Проверка Z
            Assert.AreEqual((double)result [3], 106230, 1);
            //Проверка итоговых значений X
            Array.Sort((Int32 [])result [4]); //просто в начале нужно указать интересующие Х
            testRes = new [] { 0, 0, 1, 2, 3, 4 };
            Assert.AreEqual(result [4], testRes);
            expected = (double [])result [1];
            actual = new double [] { 500, 700, 500, 400, 300, 1635 };
            for (int ex = 0; ex < expected.Length; ex++)
            {
                Assert.AreEqual(expected [ex], actual [ex], 1);
            }
            
            FS.VecB = new Double [] { 1700, 1600 };
            FS.MatrixA = new Double [,]
            {
                {3,2},
                {4,5},
            };
            FS.VecC = new double [] { -2, -4 };
            FS.Znak = new string [] { "<", "<" };
            result = FS.StartProgram();

            //Проверка Z
            Assert.AreEqual((double)result [3], -1400, 1);
            //Проверка итоговых значений X
            Array.Sort((Int32 [])result [4]); //просто в начале нужно указать интересующие Х
            testRes = new [] { 1, 2 };
            Assert.AreEqual(result [4], testRes);
           
            expected = (double [])result [1];
            actual = new double [] { 300, 200 };
            for (int ex = 0; ex < expected.Length; ex++)
            {
                Assert.AreEqual(expected [ex], actual [ex], 1);
            }
        }
    }
}