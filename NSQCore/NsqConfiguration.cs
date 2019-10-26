using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSQCore
{
	public class NsqConfiguration
	{
		public string ConnectionString { get; set; }
		public ILoggerFactory LoggerFactory { get; set; }
	}
}
