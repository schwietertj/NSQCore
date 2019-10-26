using Microsoft.Extensions.Logging;

namespace NSQCore.System
{
	internal static class ConsoleLogger
	{
		public static ILoggerFactory LoggerFactory { get; }

		static ConsoleLogger()
		{
			LoggerFactory = Microsoft.Extensions.Logging.LoggerFactory.Create(configure => configure.AddConsole());			
		}
	}
}
