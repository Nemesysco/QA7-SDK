using System;
using System.IO;

using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;

namespace NMS.Core.Utility
{
    public static class NmsLogger
    {
        private static ILog _log;


        public static void Init(string folder)
        {
            var appender = new RollingFileAppender
            {
                Name = "AppLogAppender",
                File = Path.Combine(folder, "Logs", "log-file.txt"),
                AppendToFile = true,
                LockingModel = new FileAppender.MinimalLock(),
                Layout = new PatternLayout("%date{dd.MM.yyyy HH:mm:ss} %-5level - %message%newline"),
                Threshold = Level.All,
                MaximumFileSize = "10MB",
                MaxSizeRollBackups = 20,
                RollingStyle = RollingFileAppender.RollingMode.Date,
                StaticLogFileName = true,
                DatePattern = ".yyyy.MM.dd"
            };

            appender.ActivateOptions();

            var log = LogManager.GetLogger("AppLog");
            var logger = (Logger)log.Logger;
            logger.AddAppender(appender);
            logger.Repository.Configured = true;

            _log = log;
        }

        public static bool IsDebugEnabled
        {
            get { return _log.IsDebugEnabled; }
        }

        public static bool IsInfoEnabled
        {
            get { return _log.IsInfoEnabled; }
        }

        public static bool IsWarnEnabled
        {
            get { return _log.IsWarnEnabled; }
        }

        public static bool IsErrorEnabled
        {
            get { return _log.IsErrorEnabled; }
        }

        public static bool IsFatalEnabled
        {
            get { return _log.IsFatalEnabled; }
        }

        public static void Debug(string message)
        {
            _log.Debug(message);
        }

        public static void Info(string message)
        {
            _log.Info(message);
        }

        public static void Warn(string message)
        {
            _log.Warn(message);
        }

        public static void Error(string message)
        {
            _log.Error(message);
        }

        public static void Fatal(string message)
        {
            _log.Fatal(message);
        }

        public static void Debug(Exception t)
        {
            _log.Debug(t.Message, t);
        }

        public static void Info(Exception t)
        {
            _log.Info(t.Message, t);
        }

        public static void Warn(Exception t)
        {
            _log.Warn(t.Message, t);
        }

        public static void Error(Exception t)
        {
            _log.Error(t.Message, t);
        }

        public static void Fatal(Exception t)
        {
            _log.Fatal(t.Message, t);
        }

        public static void DebugFormat(string format, params object[] args)
        {
            _log.DebugFormat(format, args);
        }

        public static void InfoFormat(string format, params object[] args)
        {
            _log.InfoFormat(format, args);
        }

        public static void WarnFormat(string format, params object[] args)
        {
            _log.WarnFormat(format, args);
        }

        public static void ErrorFormat(string format, params object[] args)
        {
            _log.ErrorFormat(format, args);
        }

        public static void FatalFormat(string format, params object[] args)
        {
            _log.FatalFormat(format, args);
        }

        public static void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            _log.DebugFormat(provider, format, args);
        }

        public static void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            _log.InfoFormat(provider, format, args);
        }

        public static void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            _log.WarnFormat(provider, format, args);
        }

        public static void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            _log.ErrorFormat(provider, format, args);
        }

        public static void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            _log.FatalFormat(provider, format, args);
        }
    }
}
