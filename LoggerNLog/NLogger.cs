using LogInterface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerNLog
{
    public class NLogger : LoggerBase
    {
        private readonly string _appID;

        private readonly string _instanceID;

        private readonly NLog.Logger _logger;

        public NLogger(string AppID, string InstanceID, NLog.Logger logger)
        {
            _appID = AppID;
            _instanceID = InstanceID;
            _logger = logger;
        }

        public override bool IsDebugEnabled { get { return _logger.IsDebugEnabled; } }

        public override bool IsErrorEnabled { get { return _logger.IsErrorEnabled; } }

        public override bool IsFatalEnabled { get { return _logger.IsFatalEnabled; } }

        public override bool IsInfoEnabled { get { return _logger.IsInfoEnabled; } }

        public override bool IsTraceEnabled { get { return _logger.IsTraceEnabled; } }

        public override bool IsWarnEnabled { get { return _logger.IsWarnEnabled; } }

        public override void Log<T>(LogLevel level, T message)
        {
            NLog.LogLevel nlogLevel = GetNLogLevel(level);
            NLog.LogEventInfo ei = new NLog.LogEventInfo(nlogLevel, _logger.Name, JsonConvert.SerializeObject(message));
            ei.Properties["AppID"] = _appID;
            ei.Properties["InstanceID"] = _instanceID;
            _logger.Log(ei);
        }

        public override void Log<T>(LogLevel level, Exception e, T message)
        {
            NLog.LogLevel nlogLevel = GetNLogLevel(level);
            NLog.LogEventInfo ei = new NLog.LogEventInfo(nlogLevel, _logger.Name, JsonConvert.SerializeObject(message));
            ei.Exception = e;
            ei.Properties["AppID"] = _appID;
            ei.Properties["InstanceID"] = _instanceID;
            _logger.Log(ei);
        }

        public override void Log(LogLevel level, string message)
        {
            NLog.LogLevel nlogLevel = GetNLogLevel(level);
            NLog.LogEventInfo ei = new NLog.LogEventInfo(nlogLevel, _logger.Name, message);
            ei.Properties["AppID"] = _appID;
            ei.Properties["InstanceID"] = _instanceID;
            _logger.Log(ei);
        }

        public override void Log(LogLevel level, Exception e)
        {
            NLog.LogLevel nlogLevel = GetNLogLevel(level);
            NLog.LogEventInfo ei = new NLog.LogEventInfo();
            ei.Level = nlogLevel;
            ei.LoggerName = _logger.Name;
            ei.Exception = e;
            ei.Properties["AppID"] = _appID;
            ei.Properties["InstanceID"] = _instanceID;
            _logger.Log(ei);
        }

        private static NLog.LogLevel GetNLogLevel(LogLevel level)
        {
            switch (level)
            {
                case LogLevel.Debug:
                    return NLog.LogLevel.Debug;
                case LogLevel.Error:
                    return NLog.LogLevel.Error;
                case LogLevel.Fatal:
                    return NLog.LogLevel.Fatal;
                case LogLevel.Info:
                    return NLog.LogLevel.Info;
                case LogLevel.Trace:
                    return NLog.LogLevel.Trace;
                case LogLevel.Warn:
                    return NLog.LogLevel.Warn;
                default:
                    throw new ArgumentException("unknown log level: " + level);
            }
        }
    }
}
