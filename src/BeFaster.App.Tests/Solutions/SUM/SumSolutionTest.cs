using BeFaster.App.Solutions.SUM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace BeFaster.App.Tests.Solutions.SUM
{
    [TestFixture]
    public class SumSolutionTest
    {
        [TestCase(1, 1, ExpectedResult = 2)]
        [TestCase(100, 100, ExpectedResult = 200)]
        [TestCase(0, 0, ExpectedResult = 0)]
        public int ComputeSum(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public int Sum_GivenFirstValueBelowRange_ThrowException()
        {
            return SumSolution.Sum(-1, 50);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public int Sum_GivenFirstValueAboveRange_ThrowException()
        {
            return SumSolution.Sum(101, 50);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public int Sum_GivenSecondValueBelowRange_ThrowException()
        {
            return SumSolution.Sum(50, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public int Sum_GivenSecondValueAboveRange_ThrowException()
        {
            return SumSolution.Sum(50, 101);
        }

    }
}

