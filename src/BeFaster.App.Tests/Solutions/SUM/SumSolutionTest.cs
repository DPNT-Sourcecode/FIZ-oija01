using BeFaster.App.Solutions.SUM;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.SUM
{
    [TestFixture]
    public class SumSolutionTest
    {
        [TestCase(1, 1, ExpectedResult = 2)]
        public int ComputeSum(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }
        [TestCase(100, 100, ExpectedResult = 200)]
        public int Sum_GivenBothatUpperRange_ReturnSum(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }
        [TestCase(0, 0, ExpectedResult = 200)]
        public int CSum_GivenBothatUpperRange_ReturnSum(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }
        [TestCase(-1,50,ExpectedResult =Exception.OutofRange)]
        public int Sum_GivenFirstValueBelowRange_ThrowException(int x, int y)
        {

        }

        [TestCase(101, 50, ExpectedResult = Exception.OutofRange)]
        public int Sum_GivenFirstValueAboveRange_ThrowException(int x, int y)
        {

        }

        [TestCase(50, -1, ExpectedResult = Exception.OutofRange)]
        public int Sum_GivenSecondValueBelowRange_ThrowException(int x, int y)
        {

        }

        [TestCase(50, 101, ExpectedResult = Exception.OutofRange)]
        public int Sum_GivenSecondValueAboveRange_ThrowException(int x, int y)
        {

        }

    }
}

