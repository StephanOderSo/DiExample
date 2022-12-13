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

        internal Client(ILogger logger)
        {
            this.logger = logger;
        }

        internal void DoSomething()
        {
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
