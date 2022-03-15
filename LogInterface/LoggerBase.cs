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
