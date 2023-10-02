using System;

public static class LogAnalysis
{
    public static string SubstringAfter(this string textInput, string delimiter)
    {
        return textInput.Split(new[] { delimiter }, StringSplitOptions.None)[1];
    }

    public static string SubstringBetween(this string text, string delimiterOne, string delimiterTwo)
    {
        int startIndex = text.IndexOf(delimiterOne);
        int endIndex = text.IndexOf(delimiterTwo, startIndex + delimiterOne.Length);

        if (startIndex != -1 && endIndex != -1)
        {
            return text.Substring(startIndex + delimiterOne.Length, endIndex - startIndex - delimiterOne.Length);
        }

        return string.Empty;
    }

    public static string Message(this string text)
    {
        return text.SubstringAfter("]: ");
    }

    public static string LogLevel(this string text)
    {
        return text.SubstringBetween("[", "]");
    }
}