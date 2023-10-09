using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = (max * (max + 1)) / 2;
        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max) => Enumerable.Range(1, max).Sum(x => x * x);

    public static int CalculateDifferenceOfSquares(int max)
    {
        int abs = CalculateSumOfSquares(max) - CalculateSquareOfSum(max);
        return Math.Abs(abs);
    }
}