using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyaleServer
{
    class Debug
    {
        public static string m_LogPath = @"ROYALE_LOG.txt";
        
        public static void LogError(string toLog)
        {
            Log(toLog, "ERROR");
        }

        public static void LogWarning(string toLog)
        {
            Log(toLog, "WARNING");
        }
        public static void LogInfo(string toLog)
        {
            Log(toLog, "INFO");
        }

        public static void Log(string toLog, string logType)
        {
            toLog = $"({TimeStamp()}):[{logType}] -> {toLog}";
            Console.WriteLine(toLog);
            File.AppendAllText(m_LogPath, toLog + Environment.NewLine);
        }

        public static string TimeStamp()
        {
            return GetTimestamp(DateTime.Now);
        }

        private static string GetTimestamp(DateTime value)
        {
            return value.ToString("MM/dd/yy HH:mm:ss");
        }
    }
}
