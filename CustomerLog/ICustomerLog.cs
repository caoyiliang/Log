namespace CustomerLog
{
    public interface ICustomerLog
    {
        Task Write(string directoryName, string content);
    }
}
