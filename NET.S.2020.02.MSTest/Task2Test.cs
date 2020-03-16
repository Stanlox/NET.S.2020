using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2020._02.MSTest
{
    [TestClass]
    public class Task2Test
    {
        [TestMethod]
        public void Test1FindNextBiggerNumber()
        {
            int expected = 21;
            int actual = Task2.FindNextBiggerNumber(12);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2FindNextBiggerNumber()
        {
            int expected = 531;
            int actual = Task2.FindNextBiggerNumber(513);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test3FindNextBiggerNumber()
        {
            int expected = 2071;
            int actual = Task2.FindNextBiggerNumber(2017);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test4FindNextBiggerNumber()
        {
            int expected = 441;
            int actual = Task2.FindNextBiggerNumber(414);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test5FindNextBiggerNumber()
        {
            int expected = 414;
            int actual = Task2.FindNextBiggerNumber(144);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test6FindNextBiggerNumber()
        {
            int expected = 1241233;
            int actual = Task2.FindNextBiggerNumber(1234321);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test7FindNextBiggerNumber()
        {
            int expected = 1234162;
            int actual = Task2.FindNextBiggerNumber(1234126);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test8FindNextBiggerNumber()
        {
            int expected = 3462345;
            int actual = Task2.FindNextBiggerNumber(3456432);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test9FindNextBiggerNumber()
        {
            int expected = -1;
            int actual = Task2.FindNextBiggerNumber(10);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test10FindNextBiggerNumber()
        {
            int expected = -1;
            int actual = Task2.FindNextBiggerNumber(20);
            Assert.AreEqual(expected, actual);
        }
    }
}
