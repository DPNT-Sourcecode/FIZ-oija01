using BeFaster.Runner.Exceptions;
using System;

namespace BeFaster.App.Solutions.SUM
{
    public static class SumSolution
    {
        public static int Sum(int x, int y)
        {
            if(!TestRange(x,0,100))
            {
                throw new ArgumentOutOfRangeException; 
            }
            return x + y;
        }

        private static bool TestRange (int number, int bottomlimit, int toplimit)
        {
            return (number >= bottomlimit && number <= toplimit);
        }
    }
}


