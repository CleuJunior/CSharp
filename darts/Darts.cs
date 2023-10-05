using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double pythagoras = Pythagoras(x, y);

        if (pythagoras <= 1)
            return 10;

        if (pythagoras <= 5)
            return 5;

        return pythagoras <= 10 ? 1 : 0;
    }

    private static double Pythagoras(double x, double y) => Math.Sqrt(x * x + y * y);
}