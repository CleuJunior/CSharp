static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        return balance switch
        {
            < 0 => 3.213f,
            < 1000 => 0.5f,
            < 5000 => 1.621f,
            _ => 2.475f
        };
    }

    public static decimal Interest(decimal balance)
    {
        var interestRate = InterestRate(balance);
        var interestAmount = balance * (decimal)(interestRate / 100);
        return interestAmount;    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        var interestAmount = Interest(balance);
        return balance + interestAmount;    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        var years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}