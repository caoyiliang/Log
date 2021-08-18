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
 * * 说明：LoggerBase.cs
 * *
********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LogInterface
{
    public abstract class LoggerBase : ILogger
    {
        public abstract bool IsDebugEnabled { get; }

        public abstract bool IsErrorEnabled { get; }

        public abstract bool IsFatalEnabled { get; }

        public abstract bool IsInfoEnabled { get; }

        public abstract bool IsTraceEnabled { get; }

        public abstract bool IsWarnEnabled { get; }

        public abstract void Log<T>(LogLevel level, T message) where T : class;

        public abstract void Log(LogLevel level, string message);

        public abstract void Log(LogLevel level, Exception e);

        public abstract void Log<T>(LogLevel level, Exception e, T message) where T : class;

        public void Debug(string message, params object[] args)
        {
            if (this.IsDebugEnabled)
                this.Log(LogLevel.Debug, new { Message = FormatMessage(message, args) });
        }

        public void Debug(Exception e, string message, params object[] args)
        {
            if (this.IsDebugEnabled)
                this.Log(LogLevel.Debug, e, new { Message = FormatMessage(message, args) });
        }

        public void Debug<T>(T message) where T : class
        {
            if (this.IsDebugEnabled)
                this.Log(LogLevel.Debug, message);
        }

        public void Debug<T>(Exception e, T message) where T : class
        {
            if (this.IsDebugEnabled)
                this.Log(LogLevel.Debug, e, message);
        }

        public void Error(string message, params object[] args)
        {
            if (this.IsErrorEnabled)
                this.Log(LogLevel.Error, new { Message = FormatMessage(message, args) });
        }

        public void Error(Exception e, string message, params object[] args)
        {
            if (this.IsErrorEnabled)
                this.Log(LogLevel.Error, e, new { Message = FormatMessage(message, args) });
        }

        public void Error<T>(T message) where T : class
        {
            if (this.IsErrorEnabled)
                this.Log(LogLevel.Error, message);
        }

        public void Error<T>(Exception e, T message) where T : class
        {
            if (this.IsErrorEnabled)
                this.Log(LogLevel.Error, e, message);
        }

        public void Fatal(string message, params object[] args)
        {
            if (this.IsFatalEnabled)
                this.Log(LogLevel.Fatal, new { Message = FormatMessage(message, args) });
        }

        public void Fatal(Exception e, string message, params object[] args)
        {
            if (this.IsFatalEnabled)
                this.Log(LogLevel.Fatal, e, new { Message = FormatMessage(message, args) });
        }

        public void Fatal<T>(T message) where T : class
        {
            if (this.IsFatalEnabled)
                this.Log(LogLevel.Fatal, message);
        }

        public void Fatal<T>(Exception e, T message) where T : class
        {
            if (this.IsFatalEnabled)
                this.Log(LogLevel.Fatal, e, message);
        }

        public void Info(string message, params object[] args)
        {
            if (this.IsInfoEnabled)
                this.Log(LogLevel.Info, new { Message = FormatMessage(message, args) });
        }

        public void Info(Exception e, string message, params object[] args)
        {
            if (this.IsInfoEnabled)
                this.Log(LogLevel.Info, e, new { Message = FormatMessage(message, args) });
        }

        public void Info<T>(T message) where T : class
        {
            if (this.IsInfoEnabled)
                this.Log(LogLevel.Info, message);
        }

        public void Info<T>(Exception e, T message) where T : class
        {
            if (this.IsInfoEnabled)
                this.Log(LogLevel.Info, e, message);
        }

        public void Trace(string message, params object[] args)
        {
            if (this.IsTraceEnabled)
                this.Log(LogLevel.Trace, new { Message = FormatMessage(message, args) });
        }

        public void Trace(Exception e, string message, params object[] args)
        {
            if (this.IsTraceEnabled)
                this.Log(LogLevel.Trace, e, new { Message = FormatMessage(message, args) });
        }

        public void Trace<T>(T message) where T : class
        {
            if (this.IsTraceEnabled)
                this.Log(LogLevel.Trace, message);
        }

        public void Trace<T>(Exception e, T message) where T : class
        {
            if (this.IsTraceEnabled)
                this.Log(LogLevel.Trace, e, message);
        }

        public void Warn(string message, params object[] args)
        {
            if (this.IsWarnEnabled)
                this.Log(LogLevel.Warn, new { Message = FormatMessage(message, args) });
        }

        public void Warn(Exception e, string message, params object[] args)
        {
            if (this.IsWarnEnabled)
                this.Log(LogLevel.Warn, e, new { Message = FormatMessage(message, args) });
        }

        public void Warn<T>(T message) where T : class
        {
            if (this.IsWarnEnabled)
                this.Log(LogLevel.Warn, message);
        }

        public void Warn<T>(Exception e, T message) where T : class
        {
            if (this.IsWarnEnabled)
                this.Log(LogLevel.Warn, e, message);
        }

        public void Debug(string message)
        {
            if (this.IsDebugEnabled)
                this.Log(LogLevel.Debug, message);
        }

        public void Debug(Exception e)
        {
            if (this.IsDebugEnabled)
                this.Log(LogLevel.Debug, e);
        }

        public void Error(string message)
        {
            if (this.IsErrorEnabled)
                this.Log(LogLevel.Error, message);
        }

        public void Error(Exception e)
        {
            if (this.IsErrorEnabled)
                this.Log(LogLevel.Error, e);
        }

        public void Fatal(string message)
        {
            if (this.IsFatalEnabled)
                this.Log(LogLevel.Fatal, message);
        }

        public void Fatal(Exception e)
        {
            if (this.IsFatalEnabled)
                this.Log(LogLevel.Fatal, e);
        }

        public void Info(string message)
        {
            if (this.IsInfoEnabled)
                this.Log(LogLevel.Info, message);
        }

        public void Info(Exception e)
        {
            if (this.IsInfoEnabled)
                this.Log(LogLevel.Info, e);
        }

        public void Trace(string message)
        {
            if (this.IsTraceEnabled)
                this.Log(LogLevel.Trace, message);
        }

        public void Trace(Exception e)
        {
            if (this.IsTraceEnabled)
                this.Log(LogLevel.Trace, e);
        }

        public void Warn(string message)
        {
            if (this.IsWarnEnabled)
                this.Log(LogLevel.Warn, message);
        }

        public void Warn(Exception e)
        {
            if (this.IsWarnEnabled)
                this.Log(LogLevel.Warn, e);
        }

        private string FormatMessage(string message, params object[] args)
        {
            try
            {
                return string.Format(message, args);
            }
            catch (Exception)
            {
                return message;
            }
        }
    }
}
