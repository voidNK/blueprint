using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Extensions.Logging;

namespace Blueprint.Common.Extensions.Logging
{
  public static class Extensions
  {
    public static IHostBuilder UseSerilog(this IHostBuilder builder)
    {
      Log.Logger = (ILogger) new LoggerConfiguration().ReadFrom.Configuration((IConfiguration) new ConfigurationBuilder().AddJsonFile("AppSettings.json").AddEnvironmentVariables().Build()).CreateLogger();
      SerilogHostBuilderExtensions.UseSerilog(builder, (ILogger) null, false, (LoggerProviderCollection) null);
      return builder;
    }
  }
}
