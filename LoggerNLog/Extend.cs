using LogInterface;
using Microsoft.Extensions.DependencyInjection;

namespace LoggerNLog
{
    public static class Extend
    {
        public static IServiceCollection AddNLog(this IServiceCollection services) => services.AddSingleton<ILogFactory, NLogFactory>();
    }
}
