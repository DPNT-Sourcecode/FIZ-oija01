﻿using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            bool isFizz = CheckFizzBuzzNumber(number,3);
            bool isBuzz = CheckFizzBuzzNumber(number, 5);

            if (isFizz && isBuzz)
            { return "fizz buzz"; }

            if(isFizz)
            { return "fizz"; }

            if(isBuzz)
            { return "buzz"; }

            return number.ToString();
        }

        private static bool CheckFizzBuzzNumber(int number, int check)
        {
            return (number % check == 0 || number.ToString().Contains(check.ToString()));
        }
    }
}
