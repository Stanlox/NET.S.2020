﻿using System;
using System.Collections.Generic;
using System.Text;
using NET.S._2020._04;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ConverterTests
    {
        [Test]
        [TestCase(-255.255, ExpectedResult = "1100000001101111111010000010100011110101110000101000111101011100")]
        [TestCase(255.255, ExpectedResult = "0100000001101111111010000010100011110101110000101000111101011100")]
        [TestCase(4294967295.0, ExpectedResult ="0100000111101111111111111111111111111111111000000000000000000000" )]
        [TestCase(double.MinValue, ExpectedResult ="1111111111101111111111111111111111111111111111111111111111111111" )]
        [TestCase(double.MaxValue, ExpectedResult ="0111111111101111111111111111111111111111111111111111111111111111" )]
        [TestCase(double.Epsilon, ExpectedResult ="0000000000000000000000000000000000000000000000000000000000000001" )]
        [TestCase(double.NaN, ExpectedResult ="1111111111111000000000000000000000000000000000000000000000000000" )]
        [TestCase(double.NegativeInfinity, ExpectedResult ="1111111111110000000000000000000000000000000000000000000000000000" )]
        [TestCase(double.PositiveInfinity, ExpectedResult ="0111111111110000000000000000000000000000000000000000000000000000" )]
        [TestCase(-0.0, ExpectedResult ="1000000000000000000000000000000000000000000000000000000000000000")]
        [TestCase(0.0, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000000")]
        public string ExtensionMethod_ConverterToString_ReturnCorrectString(double testNumber)
        {
            return ConverterToString.DoubleNumberConvertToString(testNumber);
        }
    }
}