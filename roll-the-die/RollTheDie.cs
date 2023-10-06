using System;

public class Player
{
    public int RollDie() => new Random().Next(1, 19);

    public double GenerateSpellStrength()
    {
        double inRange = new Random().NextDouble();

        return inRange > 100.0 ? 100.0 : inRange;
    }
}