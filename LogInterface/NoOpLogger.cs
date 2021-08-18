using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInterface
{
    /// <summary>
    /// do nothing
    /// </summary>
    public class NoOpLogger : LoggerBase
    {
        public override bool IsDebugEnabled
        {
            get
            {
                return false;
            }
        }

        public override bool IsErrorEnabled
        {
            get
            {
                return false;
            }
        }

        public override bool IsFatalEnabled
        {
            get
            {
                return false;
            }
        }

        public override bool IsInfoEnabled
        {
            get
            {
                return false;
            }
        }

        public override bool IsTraceEnabled
        {
            get
            {
                return false;
            }
        }

        public override bool IsWarnEnabled
        {
            get
            {
                return false;
            }
        }

        public override void Log<T>(LogLevel level, T message)
        {

        }

        public override void Log<T>(LogLevel level, Exception e, T message)
        {

        }

        public override void Log(LogLevel level, string message)
        {

        }

        public override void Log(LogLevel level, Exception e)
        {

        }
    }
}
