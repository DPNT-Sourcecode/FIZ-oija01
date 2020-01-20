using BeFaster.App.Solutions.SUM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace BeFaster.App.Tests.Solutions.SUM
{
    [TestFixture]
    public class SumSolutionTest
    {
        //Test Valid Sums
        [TestCase(1, 1, ExpectedResult = 2)]
        [TestCase(100, 100, ExpectedResult = 200)]
        [TestCase(0, 0, ExpectedResult = 0)]
        public int ComputeSum(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        //Test Out of Range values
        [TestCase (-1,50)]
        [TestCase (101,50)]
        [TestCase (50,-1)]
        [TestCase (50,101)]
        public void Sum_GivenValueOutofRange_ThrowException(int x, int y)
        {
            NUnit.Framework.Assert.Throws<ArgumentOutOfRangeException>(() => SumSolution.Sum(x, y));
        }

    }
}
