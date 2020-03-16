using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2020._02.MSTest
{

    [TestClass]
    public class Task1Test
    {
        [TestMethod]
        public void Test1InsertNumber()
        {
            int expected = 15;
            int actual = Task1.InsertNumber(15, 15, 0, 0);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Test2InsertNumber()
        {
            int expected = 9;
            int actual = Task1.InsertNumber(8, 15, 0, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test3InsertNumber()
        {
            int expected = 120;
            int actual = Task1.InsertNumber(8, 15, 3, 8);
            Assert.AreEqual(expected, actual);
        }
    }
}
