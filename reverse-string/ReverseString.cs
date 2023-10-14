using System.Text;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        StringBuilder reverse = new StringBuilder();

        foreach (var c in input.ToCharArray())
            reverse.Insert(0, c);
        
        return reverse.ToString();
    }
}