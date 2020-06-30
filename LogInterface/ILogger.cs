using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace LogInterface
{
    public interface ILogger
    {
        /// <summary>
        /// Checks if this logger is enabled for the <see cref="LogLevel.Debug" /> level.
        /// </summary>
        bool IsDebugEnabled { get; }

        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="LogLevel.Error" /> level.
        /// </summary>
        bool IsErrorEnabled { get; }

        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="LogLevel.Fatal" /> level.
        /// </summary>
        bool IsFatalEnabled { get; }

        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="LogLevel.Info" /> level.
        /// </summary>
        bool IsInfoEnabled { get; }

        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="LogLevel.Trace" /> level.
        /// </summary>
        bool IsTraceEnabled { get; }

        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="LogLevel.Warn" /> level.
        /// </summary>
        bool IsWarnEnabled { get; }

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        /// <param name="messgae"></param>
        void Debug(string message);
        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        void Debug(string message, params object[] args);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        void Debug(Exception e);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        void Debug(Exception e, string message, params object[] args);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        void Debug<T>(T message) where T : class;

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Debug"/> level.
        /// </summary>
        void Debug<T>(Exception e, T message) where T : class;

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        void Error(string message);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        void Error(string message, params object[] args);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        void Error(Exception e);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        void Error(Exception e, string message, params object[] args);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        void Error<T>(T message) where T : class;

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Error"/> level.
        /// </summary>
        void Error<T>(Exception e, T message) where T : class;

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Fatal"/> level.
        /// </summary>
        void Fatal(string message);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Fatal"/> level.
        /// </summary>
        void Fatal(string message, params object[] args);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Fatal"/> level.
        /// </summary>
        void Fatal(Exception e);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Fatal"/> level.
        /// </summary>
        void Fatal(Exception e, string message, params object[] args);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Fatal"/> level.
        /// </summary>
        void Fatal<T>(T message) where T : class;

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Fatal"/> level.
        /// </summary>
        void Fatal<T>(Exception e, T message) where T : class;

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Info"/> level.
        /// </summary>
        void Info(string message);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Info"/> level.
        /// </summary>
        void Info(string message, params object[] args);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Info"/> level.
        /// </summary>
        void Info(Exception e);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Info"/> level.
        /// </summary>
        void Info(Exception e, string message, params object[] args);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Info"/> level.
        /// </summary>
        void Info<T>(T message) where T : class;

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Info"/> level.
        /// </summary>
        void Info<T>(Exception e, T message) where T : class;

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        void Trace(string message);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        void Trace(string message, params object[] args);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        void Trace(Exception e);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        void Trace(Exception e, string message, params object[] args);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        void Trace<T>(T message) where T : class;

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Trace"/> level.
        /// </summary>
        void Trace<T>(Exception e, T message) where T : class;

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Warn"/> level.
        /// </summary>
        void Warn(string message);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Warn"/> level.
        /// </summary>
        void Warn(string message, params object[] args);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Warn"/> level.
        /// </summary>
        void Warn(Exception e);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Warn"/> level.
        /// </summary>
        void Warn(Exception e, string message, params object[] args);

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Warn"/> level.
        /// </summary>
        void Warn<T>(T message) where T : class;

        /// <summary>
        /// Log a message object with the <see cref="LogLevel.Warn"/> level.
        /// </summary>
        void Warn<T>(Exception e, T message) where T : class;
    }
}
