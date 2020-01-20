using BeFaster.App.Solutions.SUM;
using NUnit.Framework;

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
        [ExpectedException(typeof(ArgumentOutofRangeException))]
        public int Sum_GivenFirstValueBelowRange_ThrowException()
        {
            return SumSolutionTest.Sum(-1, 50);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutofRangeException))]
        public int Sum_GivenFirstValueAboveRange_ThrowException()
        {
            return SumSolutionTest.Sum(101, 50);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutofRangeException))]
        public int Sum_GivenSecondValueBelowRange_ThrowException()
        {
            return SumSolutionTest.Sum(50, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutofRangeException))]
        public int Sum_GivenSecondValueAboveRange_ThrowException()
        {
            return SumSolutionTest.Sum(50, 101);
        }

    }
}
