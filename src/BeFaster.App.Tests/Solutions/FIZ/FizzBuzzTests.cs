﻿using BeFaster.App.Solutions.FIZ;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace BeFaster.App.Tests.Solutions.FIZ
{
    [TestFixture]
    public class FIZTest
    {

        [TestCase(1, ExpectedResult = "1")]
        [TestCase(3, ExpectedResult = "fizz")]
        [TestCase(6, ExpectedResult = "fizz")]
        [TestCase(5, ExpectedResult = "buzz")]
        [TestCase(10, ExpectedResult = "buzz")]
        [TestCase(15, ExpectedResult = "fizz buzz")]
        [TestCase(1501,ExpectedResult ="buzz")]
        [TestCase(1301,ExpectedResult = "fizz")]
        [TestCase(1531,ExpectedResult ="fizz buzz")]
        [TestCase(330, ExpectedResult = "fizz fake deluxe")]
        [TestCase(1111,ExpectedResult ="1111")]
        [TestCase(2222,ExpectedResult = "2222")]
        [TestCase(444,ExpectedResult ="fizz")]
        [TestCase(550, ExpectedResult = "fizz buzz deluxe")]
        [TestCase(5555, ExpectedResult = "buzz fake deluxe")]

        public string TestFizz (int x)
        {
            return FizzBuzzSolution.FizzBuzz(x);
        }

    }
}



