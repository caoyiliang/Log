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
