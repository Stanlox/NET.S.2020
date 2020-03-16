using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2020._02.MSTest
{
    [TestClass]
    public class Task4Test
    {
        [TestMethod]
        public void Test1FilterDigit()
        {
            int[] collection = new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            int[] expected = new int[] { 7, 7, 70, 17 };
            var actual = Task4.FilterDigit(7, collection);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2FilterDigit()
        {
            int[] collection = new int[] {5,3,7,2,43,76,2,7,34,8,34};
            int[] expected = new int[] { 43, 34, 34 };
            var actual = Task4.FilterDigit(4, collection);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
