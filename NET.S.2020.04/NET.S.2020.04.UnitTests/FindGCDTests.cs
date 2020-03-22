using NUnit.Framework;
using NET.S._2020._04.GreatestCommonDivisor;
using System;

namespace Tests
{
    [TestFixture]
    public class FindGCDTests
    {
        [Test]
        [TestCase(8, 16, ExpectedResult = 8)]
        [TestCase(5, 25, ExpectedResult = 5)]
        [TestCase(3, 8, ExpectedResult = 1)]
        [TestCase(18, 3, ExpectedResult =3)]
        public int GCDEuclideanAlgorithm_FindGCD_ReturnsCorrectGCD(int x, int y)
        {
            return FindGCD.GCDUseEuclideanAlgorithm(x, y);
        }

        [Test]
        [TestCase(new int[] { 36, 45, 81, 9, 54, 3 }, ExpectedResult = 3)]
        [TestCase(new int[] { int.MaxValue, 23, 45 }, ExpectedResult = 1)]
        [TestCase(new int[] { 14, 28, 56, 112 }, ExpectedResult = 14)]
        public int GCDEuclideanAlgorithm_FindGCD_ReturnsCorrectGCD(int[] number)
        {
            return FindGCD.GCDUseEuclideanAlgorithm(number);
        }

        [Test]
        [TestCase(new int[] { 1 })]
        public void GCDEuclideanAlgorithm_FindGCD_ReturnsArgumentException(int[] number)
        {
            Assert.Throws<ArgumentException>(() => FindGCD.GCDUseEuclideanAlgorithm(number));
        }
        [Test]
        [TestCase(new int[] { 1 })]
        public void GCDUseSteinaAlgorithm_FindGCD_ReturnsArgumentException(int[] number)
        {
            Assert.Throws<ArgumentException>(() => FindGCD.GCDUseEuclideanAlgorithm(number));
        }


        [Test]
        [TestCase(8, 16, ExpectedResult = 8)]
        [TestCase(5, 25, ExpectedResult = 5)]
        [TestCase(3, 8, ExpectedResult = 1)]
        [TestCase(18, 3, ExpectedResult = 3)]
        public int GCDSteinAlgorithm_FindGCD_ReturnsCorrectGCD(int x, int y)
        {
            return FindGCD.GCDUseSteinaAlgorithm(x, y);
        }

        [Test]
        [TestCase(new int[] { 36, 45, 81, 9, 54, 3 }, ExpectedResult = 3)]
        [TestCase(new int[] { int.MaxValue, 23, 45 }, ExpectedResult = 1)]
        [TestCase(new int[] { 14, 28, 56, 112 }, ExpectedResult = 14)]
        public int GCDSteinAlgorithm_FindGCD_ReturnsCorrectGCD(int[] number)
        {
            return FindGCD.GCDUseSteinaAlgorithm(number);
        }
    }
}