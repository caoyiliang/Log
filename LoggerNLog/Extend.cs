using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using LogInterface;

namespace LoggerNLog
{
    public static class Extend
    {
        public static IServiceCollection UseNLog(this IServiceCollection services) => services.AddSingleton<ILogFactory, NLogFactory>();
    }
}
