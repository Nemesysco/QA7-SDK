using log4net;
using System;
using System.Reflection;

namespace NMS.Core.Utility
{
    public static class NmsLogger
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);


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
