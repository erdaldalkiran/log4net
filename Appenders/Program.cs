using System;
using System.Threading;
using log4net;
using log4net.Appender;

namespace Appenders
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            var logger = LogManager.GetLogger(typeof (Program));
            
            //var appender = new RollingFileAppender();
            //appender.PreserveLogFileNameExtension

            logger.Debug("Debug");
            logger.Info("Info");
            Console.WriteLine($"Now: {DateTime.Now}");
            logger.Warn("Warn");
            logger.Error("Error");
            logger.Fatal("Fatal");


            //For rolling file/telnet appender
            while (!Console.KeyAvailable)
            {
                logger.Error(DateTime.Now.ToLongDateString());
                Thread.Sleep(100);
            }

            Console.ReadKey();
        }
    }
}