using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInterface
{
    /// <summary>
    /// 用于获取ILogger对象
    /// </summary>
    public interface ILogFactory
    {
        ILogger GetLogger(string loggerName);
        ILogger GetLogger(Type type);
        ILogger GetLogger<T>();
    }
}
