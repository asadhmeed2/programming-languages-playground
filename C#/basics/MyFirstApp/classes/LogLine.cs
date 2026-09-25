enum LogLevel
{
    Trace = 1,
    Debug = 2   ,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
    Unknown = 0 
};
static class LogLine
{
    private static Dictionary<string, LogLevel> dict = new Dictionary<string, LogLevel>()
    {
        {"TRC" , LogLevel.Trace},
        {"DBG" , LogLevel.Debug},
        {"INF" , LogLevel.Info},
            {"WRN" ,LogLevel.Warning},
                {"ERR" , LogLevel.Error},
                    {"FTL", LogLevel.Fatal}
    };

    public static LogLevel ParseLogLevel(string logLine)
    {
        // if(logLine.Length < 4){
        //     return String.Empty;
        // }

        string str = logLine.Substring(logLine.IndexOf('[') + 1, logLine.IndexOf(']')-1 );

        var exists = LogLine.dict.TryGetValue(str, out LogLevel log);
        

        if(!exists)
        {
            return LogLevel.Unknown;
        }
        return  log;
    }

    

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }
}
