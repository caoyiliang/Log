using System;
using System.Threading.Tasks;

namespace CustomerLog
{
    public interface ICustomerLog
    {
        void Write(string directoryName, string content);
    }
}
