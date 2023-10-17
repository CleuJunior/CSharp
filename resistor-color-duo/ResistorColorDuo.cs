using System.Collections.Generic;

public static class ResistorColorDuo
{
    private static readonly Dictionary<string, int> ResistorDictionary = new()
    {
        { "black", 0 },
        { "brown", 1 },
        { "red", 2 },
        { "orange", 3 },
        { "yellow", 4 },
        { "green", 5 },
        { "blue", 6 },
        { "violet", 7 },
        { "grey", 8 },
        { "white", 9 }
    };

    public static int Value(string[] colors) =>
        $"{ResistorDictionary[colors[0]]}{ResistorDictionary[colors[1]]}".StringToInt();

    private static int StringToInt(this string text) => int.Parse(text);
}