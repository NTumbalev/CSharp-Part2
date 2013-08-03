using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04.Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestForOnlyOneFinded()
        {
            int number = 2;
            int[] array = new int[] { 1, 2, 3 };
            int count = CountOfAppearedNumber.FindAndCount(number, array);
            Assert.AreEqual(count, 1);
        }

        [TestMethod]
        public void TestForSameNumbers()
        {
            int number = 2;
            int[] array = new int[] { 2, 2, 2 };
            int count = CountOfAppearedNumber.FindAndCount(number, array);
            Assert.AreEqual(count, 3);
        }

        [TestMethod]
        public void TestForFirstAndLastTwo()
        {
            int number = 2;
            int[] array = new int[] { 2, 1, 3, 5, 2, 2 };
            int count = CountOfAppearedNumber.FindAndCount(number, array);
            Assert.AreEqual(count, 3);
        }

        [TestMethod]
        public void TestForMiddleEquals()
        {
            int number = 2;
            int[] array = new int[] { 4, 1, 2, 2, 2, 8, 6 };
            int count = CountOfAppearedNumber.FindAndCount(number, array);
            Assert.AreEqual(count, 3);
        }

        [TestMethod]
        public void TestForNotFindedElement()
        {
            int number = 2;
            int[] array = new int[] { 1, 1, 3, 5, 5, 6, 7 };
            int count = CountOfAppearedNumber.FindAndCount(number, array);
            Assert.AreEqual(count, 0);
        }
    }
}
