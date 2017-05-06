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
            File.AppendAllText(m_LogPath, $"({TimeStamp()})[!ERROR!] -> {toLog}"+ Environment.NewLine);
        }

        public static void LogWarning(string toLog)
        {
            File.AppendAllText(m_LogPath, $"({TimeStamp()})[WARNING] -> {toLog}" + Environment.NewLine);
        }
        public static void LogInfo(string toLog)
        {
            File.AppendAllText(m_LogPath, $"({TimeStamp()})[INFO] -> {toLog}" + Environment.NewLine);
        }

        public static string TimeStamp()
        {
            return GetTimestamp(DateTime.Now);
        }

        private static string GetTimestamp(DateTime value)
        {
            return value.ToString("MM/dd/yyyy HH:mm:ss");
        }
    }
}
