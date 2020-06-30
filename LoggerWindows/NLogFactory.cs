using LogInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerWindows
{
    public class NLogFactory : ILogFactory
    {
        private readonly string _appID;
        private readonly string _instanceID;

        public NLogFactory(string AppID, string InstanceID)
        {
            _appID = AppID;
            _instanceID = InstanceID;
        }

        public NLogFactory():this("Must Have AppID", "Must Have InstanceID")
        {

        }

        public ILogger GetLogger(string loggerName)
        {
            return new NLogger(_appID, _instanceID, NLog.LogManager.GetLogger(loggerName));
        }

        public ILogger GetLogger(Type type)
        {
            return GetLogger(type.Name);
        }

        public ILogger GetLogger<T>()
        {
            return GetLogger(typeof(T));
        }
    }
}
