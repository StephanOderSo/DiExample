using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DiExampleConsole
{
    internal interface ILogger
    {
        /// <summary>
        /// Write Logs
        /// </summary>
        /// <param name="message">Logmessage</param>
        /// <param name="logLevel"></param>
        /// <param name="line">Caller line</param>
        /// <param name="caller">Callermember</param>
        /// <param name="path">callerpath, Execpath</param>
        void Log(string message, LogLevel logLevel, [CallerLineNumber] int line = 0, [CallerMemberName] string caller = "", [CallerFilePath] string path = "");
     
    }
}
