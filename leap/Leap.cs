public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool isDividedByOneHundredAndNotByFourHundred = (year % 100 != 0 || year % 400 == 0);
        
        return (year % 4 == 0 && isDividedByOneHundredAndNotByFourHundred);
    }
}