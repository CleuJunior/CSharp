using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();

        if (string.IsNullOrEmpty(statement))
            return "Fine. Be that way!";

        if (IsQuestion(statement) && IsYelling(statement))
            return "Calm down, I know what I'm doing!";

        if (IsQuestion(statement))
            return "Sure.";

        return IsYelling(statement) ? "Whoa, chill out!" : "Whatever.";
    }

    private static bool IsQuestion(string input) => input.EndsWith('?');

    private static bool IsYelling(string input) => input.Equals(input.ToUpper()) && input.Any(char.IsLetter);
}