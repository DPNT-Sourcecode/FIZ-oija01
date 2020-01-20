using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            bool isFizz = (number % 3 == 0);
            bool isBuzz = (number % 5 == 0);

            if(isFizz && isBuzz)
            { return "fizz buzz"; }

            if(isFizz)
            { return "fizz"; }

            if(isBuzz)
            { return "buzz"; }

            return number.ToString();
        }
    }
}

