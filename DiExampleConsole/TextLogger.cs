using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DiExampleConsole
{
    internal class TextLogger : ILogger
    {
        public void Log(string message, LogLevel logLevel, [CallerLineNumber] int line = 0, [CallerMemberName] string caller = "", [CallerFilePath] string path = "")
        {
            throw new NotImplementedException();
        }
    }
}
