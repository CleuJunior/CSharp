using System;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        string str = "";
        for (int i = startBottles; i > startBottles - takeDown; i--)
            if (i > 2)
                str += i + " bottles of beer on the wall, " + i +
                       " bottles of beer.\nTake one down and pass it around, " + (i - 1) +
                       " bottles of beer on the wall.\n\n";
            else if (i == 2)
                str +=
                    "2 bottles of beer on the wall, 2 bottles of beer.\nTake one down and pass it around, 1 bottle of beer on the wall.\n\n";
            else if (i == 1)
                str +=
                    "1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.\n\n";
            else if (i == 0)
                return str +
                       "No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.";
        return str[..^2];
    }
}