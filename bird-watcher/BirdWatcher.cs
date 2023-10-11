using System.Linq;

class BirdCount
{
    private readonly int[] _birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        _birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new[] { 0, 2, 5, 3, 7, 8, 4 };

    public int Today() => _birdsPerDay[6];

    public void IncrementTodaysCount() => _birdsPerDay[6] += 1;

    public bool HasDayWithoutBirds() => _birdsPerDay.Any(b => b == 0);

    public int CountForFirstDays(int numberOfDays) => _birdsPerDay.Take(numberOfDays).Sum();

    public int BusyDays() => _birdsPerDay.Count(b => b > 4);
}