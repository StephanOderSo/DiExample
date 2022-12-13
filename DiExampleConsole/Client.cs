using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiExampleConsole
{
    internal class Client
    {
        ILogger logger;

        /// <summary>
        /// Client doesn't care about ILogger Classtype
        /// Type will be injected by constructor, from outside
        /// </summary>
        /// <param name="logger"></param>
        internal Client(ILogger logger)
        {
            this.logger = logger;
        }

        internal void DoSomething()
        {
            // Whether the Textlogger or ClientLogger is used is determined by the injection in the constructor
            logger.Log("Something happening here...", LogLevel.Informational);

            Console.WriteLine("Something happening here...");

            try
            {
                throw new Exception("Something went wrong...");
            }
            catch (Exception ex)
            {
                logger.Log(ex.Message, LogLevel.Critical);
            }
        }
    }
}
