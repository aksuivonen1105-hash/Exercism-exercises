public static class LogAnalysis 
{
    public static string SubstringAfter(this string log, string delimiter)
    {
        int index = log.IndexOf(delimiter);
        return log.Substring (index + delimiter.Length);
    }

        
    public static string SubstringBetween(this string log, string start, string end)
    {
        int startIndex =  log.IndexOf(start);
        int endIndex = log.IndexOf(end);

       return log.Substring(startIndex + start.Length, endIndex - startIndex - start.Length);
    }

    public static string Message(this string log)
    {
        return log.SubstringAfter(": ");
    }
    

    public static string LogLevel(this string log)
    {
        return log.SubstringBetween("[", "]");
    }
}