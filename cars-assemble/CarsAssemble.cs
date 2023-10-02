using System;

static class AssemblyLine
{
    private const double BaseCarProducePerMinutes = 3.68;
    private const int BaseCarProducePerHour = 221;

    public static double SuccessRate(int speed)
    {
        return speed switch
        {
            0 => 0,
            >= 1 and <= 4 => 1,
            <= 8 => 0.9,
            9 => 0.8,
            _ => 0.77
        };
    }

    public static double ProductionRatePerHour(int speed)
    {
        return speed * BaseCarProducePerHour * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return speed == 0 ? 0 : Convert.ToInt32(Math.Floor(BaseCarProducePerMinutes * speed * SuccessRate(speed)));
    }
}