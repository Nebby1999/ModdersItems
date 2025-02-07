﻿using BepInEx.Logging;
using System.Runtime.CompilerServices;

namespace ModdersItems
{
    public class MItemsLogger
    {
        public static ManualLogSource logger = null;

        public MItemsLogger(ManualLogSource logger_)
        {
            logger = logger_;
        }

        public static void LogD(object data, [CallerLineNumber] int i = 0, [CallerMemberName] string member = "")
        {
            logger.LogDebug(logString(data, i, member));
        }
        public static void LogE(object data, [CallerLineNumber] int i = 0, [CallerMemberName] string member = "")
        {
            logger.LogError(logString(data, i, member));
        }
        public static void LogF(object data, [CallerLineNumber] int i = 0, [CallerMemberName] string member = "")
        {
            logger.LogFatal(logString(data, i, member));
        }
        public static void LogI(object data, [CallerLineNumber] int i = 0, [CallerMemberName] string member = "")
        {
            logger.LogInfo(logString(data, i, member));
        }
        public static void LogM(object data, [CallerLineNumber] int i = 0, [CallerMemberName] string member = "")
        {
            logger.LogMessage(logString(data, i, member));
        }
        public static void LogW(object data, [CallerLineNumber] int i = 0, [CallerMemberName] string member = "")
        {
            logger.LogWarning(logString(data, i, member));
        }

        private static string logString(object data, [CallerLineNumber] int i = 0, [CallerMemberName] string member = "")
        {
            return string.Format("{0} :: Line: {1}, Method {2}", data, i, member);
        }
    }
}
