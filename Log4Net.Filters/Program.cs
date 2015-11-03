using System;
using log4net;
using log4net.Config;

namespace Log4Net.Filters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            var logger = LogManager.GetLogger(typeof (Program));


            logger.Debug("This is a Debug message");
            logger.Info("This is a Info message");
            logger.Warn("This is a Warn message");
            logger.Error("This is a Error message");
            logger.Fatal("This is a Fatal message");

            Console.ReadKey();
        }
    }
}