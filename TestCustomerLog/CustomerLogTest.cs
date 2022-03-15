using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCustomerLog
{
    [TestClass]
    public class CustomerLogTest
    {
        [TestMethod]
        public async Task TestWriteAync()
        {
            CustomerLog.CustomerLog.Instance.Write("4017", "记录4017的日志1");
            CustomerLog.CustomerLog.Instance.Write("4017", "记录4017的日志2");

            await Task.Delay(50000);
        }
    }
}
