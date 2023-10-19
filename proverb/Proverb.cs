using System;
using System.Collections.Generic;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        var proverb = new List<string>();

        switch (subjects.Length)
        {
            case 0: return Array.Empty<string>();
            case 1: return new[] { $"And all for the want of a {subjects[0]}." };
        }

        int index = 0;
        while (index < subjects.Length - 1)
        {
            proverb.Add($"For want of a {subjects[index]} the {subjects[index + 1]} was lost.");

            index += 1;
        }

        proverb.Add($"And all for the want of a {subjects[0]}.");

        return proverb.ToArray();
    }
}