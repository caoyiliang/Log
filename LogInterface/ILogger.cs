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
 * * 说明：ILogger.cs
 * *
********************************************************************/

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
