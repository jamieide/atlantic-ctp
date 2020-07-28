using Microsoft.Extensions.DependencyInjection;
using NLog;

namespace AtlanticCovidTracker.Web.Infrastructure
{
    public static class NLogConfig
    {
        public static void Configure()
        {
            var config = new NLog.Config.LoggingConfiguration();
            //var logFile = new NLog.Targets.FileTarget("logfile") { FileName = "logfile.txt" };
            var logConsole = new NLog.Targets.ConsoleTarget("logconsole");

            //config.AddRule(LogLevel.Trace, LogLevel.Trace, logFile);
            config.AddRule(LogLevel.Info, LogLevel.Info, logConsole);
            
            LogManager.Configuration = config;
        }
    }
}
