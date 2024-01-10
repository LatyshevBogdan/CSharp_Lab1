using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Part2;
using Part3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double sideA=11.1, sideB=12.1, answer=134.31;

            Rectangle obj1 = new Rectangle(sideA, sideB);

            double exept = obj1.Area;

            Assert.AreEqual(answer, exept);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double sideA = 11.1, sideB = 12.1, answer = 46.4;

            Rectangle obj1 = new Rectangle(sideA, sideB);

            double exept = obj1.Perimeter;

            Assert.AreEqual(answer, exept);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(10, 2);
            Point p3 = new Point(0, 2);
            Figure f1 = new Figure(p1, p2, p3);
            double ans = 9;
            double expect = f1.LengthSide(p1, p2);


            Assert.AreEqual(ans, expect);
        }
    }
}