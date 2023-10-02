using System.Text;

static class LogLine
{
    private const string InfoLog = "[INFO]: ";
    private const string ErrorLog = "[ERROR]: ";
    private const string WarningLog = "[WARNING]: ";
    private const string InfoLogReformat = " (info)";
    private const string ErrorLogReformat = " (error)";
    private const string WarningLogReformat = " (warning)";
    private const string BlankSpace = "";

    public static string Message(string logLine)
    {
        return logLine
            .Replace(InfoLog, BlankSpace)
            .Replace(ErrorLog, BlankSpace)
            .Replace(WarningLog, BlankSpace)
            .Trim();
    }

    public static string LogLevel(string logLine)
    {
        if (logLine.Contains(ErrorLog))
            return "error";

        return logLine.Contains(WarningLog) ? "warning" : "info";
    }

    public static string Reformat(string logLine)
    {
        var stringResultBuilder = new StringBuilder(logLine.Trim());

        if (logLine.Contains(InfoLog))
            return stringResultBuilder.Replace(InfoLog, BlankSpace).Append(InfoLogReformat).ToString().Trim();
        
        return logLine.Contains(ErrorLog)
            ? stringResultBuilder.Replace(ErrorLog, BlankSpace).Append(ErrorLogReformat).ToString().Trim()
            : stringResultBuilder.Replace(WarningLog, BlankSpace).Append(WarningLogReformat).ToString().Trim();
    }
}