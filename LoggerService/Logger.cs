using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace LoggerService
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Trace.WriteLine(message);
        }
    }
}