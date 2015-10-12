using System;
using log4net;

namespace Log4Net.Loggers
{
    internal class Program
    {
        private static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();

            var logger = LogManager.GetLogger(typeof(Program));

            logger.Warn("Warn");

            var anotherLogger = LogManager.GetLogger(typeof(AnotherLogger));

            if (anotherLogger.IsDebugEnabled)
            {
                //not going to shown up at logs
                anotherLogger.Debug("Debug");
            }

            anotherLogger.Error("Error");

            Console.ReadKey();
        }
    }
}