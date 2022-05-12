using Utils.PushQueue;

namespace CustomerLog
{
    public class CustomerLog : ICustomerLog
    {
        public static readonly ICustomerLog Instance = new CustomerLog();
        private readonly PushQueue<DirectoryNameAndContent> _pushQueue;
        private CustomerLog()
        {
            _pushQueue = new PushQueue<DirectoryNameAndContent>()
            {
                MaxCacheCount = 100
            };
            _pushQueue.OnPushData += PushQueue_OnPushData;
            _pushQueue.StartAsync().Wait();
        }

        private async Task PushQueue_OnPushData(DirectoryNameAndContent arg)
        {
            var path = Path.Combine("Logs", $"{DateTime.Now:yyyyMM}", arg.DirectoryName);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            var fileName = Path.Combine(path, $"{DateTime.Now:yyyyMMdd}.txt");
            File.AppendAllText(fileName, arg.Content);
            await Task.CompletedTask;
        }

        private string AddTime(string msg)
        {
            return $"{DateTime.Now:yyyy/MM/dd HH:mm:ss:fff}    {msg}{Environment.NewLine}";
        }

        public void Write(string directoryName, string content)
        {
            _pushQueue.PutInData(new DirectoryNameAndContent()
            {
                DirectoryName = directoryName,
                Content = AddTime(content),
            });
        }
    }
    internal class DirectoryNameAndContent
    {
        internal string DirectoryName { get; set; } = null!;
        internal string Content { get; set; } = null!;
    }
}
