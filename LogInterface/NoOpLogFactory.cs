using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInterface
{
    /// <summary>
    /// 返回NoOpLogger
    /// </summary>
    public class NoOpLogFactory : ILogFactory
    {
        public ILogger GetLogger(Type type)
        {
            return new NoOpLogger();
        }

        public ILogger GetLogger(string loggerName)
        {
            return new NoOpLogger();
        }

        public ILogger GetLogger<T>()
        {
            return new NoOpLogger();
        }
    }
}
