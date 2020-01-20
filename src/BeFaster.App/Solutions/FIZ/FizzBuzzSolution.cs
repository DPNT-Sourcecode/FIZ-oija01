using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            bool isFizz = CheckFizzBuzzNumber(number,3);
            bool isBuzz = CheckFizzBuzzNumber(number, 5);
            bool isDeluxe = CheckDeluxe(number, 10);
            if (isFizz && isBuzz && isDeluxe)
            { return "fizz buzz deluxe"; }

            if (isDeluxe)
            { return "deluxe"; }

            if (isFizz && isBuzz)
            { return "fizz buzz"; }

            if (isFizz)
            { return "fizz"; }

            if(isBuzz)
            { return "buzz"; }



            return number.ToString();
        }

        private static bool CheckFizzBuzzNumber(int number, int check)
        {
            return (number % check == 0 || number.ToString().Contains(check.ToString()));
        }

        private static bool CheckDeluxe(int number,int greaterthan)
        {
            int digits = number.ToString().Length;
            char firstdigit = number.ToString()[0];
            var samenums = number.ToString().Split(firstdigit).Length - 1 ;
            return (number > greaterthan && samenums==digits);
        }
    }
}



