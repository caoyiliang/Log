/********************************************************************
 * *
 * * 使本项目源码或本项目生成的DLL前请仔细阅读以下协议内容，如果你同意以下协议才能使用本项目所有的功能，
 * * 否则如果你违反了以下协议，有可能陷入法律纠纷和赔偿，作者保留追究法律责任的权利。
 * *
 * * 1、你可以在开发的软件产品中使用和修改本项目的源码和DLL，但是请保留所有相关的版权信息。
 * * 2、不能将本项目源码与作者的其他项目整合作为一个单独的软件售卖给他人使用。
 * * 3、不能传播本项目的源码和DLL，包括上传到网上、拷贝给他人等方式。
 * * 4、以上协议暂时定制，由于还不完善，作者保留以后修改协议的权利。
 * *
 * * Copyright ©2013-? yzlm Corporation All rights reserved.
 * * 作者： 曹一梁 QQ：347739303
 * * 请保留以上版权信息，否则作者将保留追究法律责任。
 * *
 * * 创建时间：2021-06-28
 * * 说明：NLogger.cs
 * *
********************************************************************/

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
