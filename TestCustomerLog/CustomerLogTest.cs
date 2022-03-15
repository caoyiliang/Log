using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCustomerLog
{
    [TestClass]
    public class CustomerLogTest
    {
        [TestMethod]
        public async Task TestWriteAync()
        {
            CustomerLog.CustomerLog.Instance.Write("4017", "��¼4017����־1");
            CustomerLog.CustomerLog.Instance.Write("4017", "��¼4017����־2");

            await Task.Delay(50000);
        }
    }
}
