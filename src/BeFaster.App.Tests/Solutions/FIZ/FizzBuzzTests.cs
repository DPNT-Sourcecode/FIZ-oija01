using BeFaster.App.Solutions.FIZ;
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
        [TestCase(1111,ExpectedResult ="deluxe")]
        public string TestFizz (int x)
        {
            return FizzBuzzSolution.FizzBuzz(x);
        }


        [TestCase(1111, ExpectedResult = "deluxe")]
        [TestCase(5555, ExpectedResult = "deluxe")]
        public string TestDeluxe(int x)
        {
            return FizzBuzzSolution.FizzBuzz(x);
        }







        [TestCase]
        public void WriteAllFizzBuzzDeluxeNumber()
        {
            int i = 1;
            while (i < 9999)
            {
                string s = FizzBuzzSolution.FizzBuzz(i);
                if (s=="fizz buzz deluxe")
                {
                    System.Diagnostics.Debug.WriteLine(i.ToString());
                }
                i++;
            }
        }

    }
}



