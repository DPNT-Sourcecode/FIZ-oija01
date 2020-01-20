using BeFaster.Runner.Exceptions;
using System.Text;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            bool isFizz = CheckFizzBuzzNumber(number,3);
            bool isBuzz = CheckFizzBuzzNumber(number, 5);
            bool isDeluxe = CheckDeluxe(number, 10);
            bool isOdd = !(number % 2 == 0);

            StringBuilder retval = new StringBuilder() ;

            if (isFizz)
            { retval.Append("fizz "); }

            if(isBuzz)
            { retval.Append("buzz "); }

            if(isDeluxe && isOdd)
            { retval.Append("fake deluxe "); }

            if(isDeluxe)
            { retval.Append("deluxe "); }

            if (retval.Length==0)
            { retval.Append(number.ToString()); }


            /*
            if (isFizz && isBuzz && isDeluxe)
            { return "fizz buzz deluxe"; }

            if (isFizz && isBuzz)
            { return "fizz buzz"; }

            if (isFizz && isDeluxe)
            { return "fizz deluxe"; }

            if (isFizz)
            { return "fizz"; }

            if (isBuzz & isDeluxe)
            { return "buzz deluxe"; }
            if (isBuzz)
            { return "buzz"; }

            if (isDeluxe)
            { return "deluxe"; }
            */


            return retval.ToString().TrimEnd();
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


