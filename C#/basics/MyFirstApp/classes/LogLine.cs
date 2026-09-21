enum LogLevel
{
    Trace,
    Debug,
    Info,
    Warning,
    Error,
    Fatal
};
static class LogLine
{
    private static Dictionary<string, LogLevel> dict = new Dictionary<string, LogLevel>()
    {
        ["TRC"] = LogLevel.Trace,
        ["DBG"] = LogLevel.Debug,
        ["INF"] = LogLevel.Info,
        ["WRN"] = LogLevel.Warning,
        ["ERR"] = LogLevel.Error,
        ["FTL"] = LogLevel.Fatal
    };

    public static LogLevel ParseLogLevel(string logLine)
    {
        // if(logLine.Length < 4){
        //     return String.Empty;
        // }

        string str = logLine.Substring(logLine.IndexOf('[') + 1, logLine.IndexOf(']') );
        

        return LogLine.dict[str];   
    }

    

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        throw new NotImplementedException("Please implement the (static) LogLine.OutputForShortLog() method");
    }
}
