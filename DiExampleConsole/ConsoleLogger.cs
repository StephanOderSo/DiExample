using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DiExampleConsole
{
    internal class ConsoleLogger : ILogger
    {

        public void Log(string message, LogLevel logLevel, [CallerLineNumber] int line = 0, [CallerMemberName] string caller = "", [CallerFilePath] string path = "")
        {
            string logMsg = string.Format("CustomLog: " + message);
            logMsg += $" --- LogLevel: {logLevel}, Line: {line}, CallerMember: {caller}, CallerFilePath: {path}{Environment.NewLine}{Environment.NewLine}";

            Console.WriteLine(logMsg);

            return;
        }
    }
}
