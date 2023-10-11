using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> uniqueValues = new HashSet<int>();

        foreach (var value in multiples)
        {
            if (value == 0)
                continue;

            for (int i = 1; i < max; i++)
            {
                if (i % value == 0)
                    uniqueValues.Add(i);
            }
        }

        return uniqueValues.Sum();
    }
}