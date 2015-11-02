using System;
using System.Globalization;
using System.Threading;
using log4net;
using log4net.Config;

namespace Log4Net.Context
{
    internal class Program
    {
        private static readonly ILog LOGGER = LogManager.GetLogger("erdal was here!");
        private static readonly Random RANDOM = new Random();

        private static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            GlobalContext.Properties["GlobalCulture"] = Thread.CurrentThread.CurrentCulture.EnglishName;

            LOGGER.Info("This is a log message");

            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
            for (var i = 0; i < 5; i++)
            {
                var thread = new Thread(ThreadEntryPoint)
                {
                    IsBackground = true,
                    CurrentCulture = cultures[RANDOM.Next(cultures.Length)]
                };

                
                thread.Start();
            }

            Console.ReadKey();
        }

        private static void ThreadEntryPoint()
        {
            ThreadContext.Properties["ThreadCulture"] = Thread.CurrentThread.CurrentCulture.EnglishName;
            LOGGER.Info("This is a thread log message");
        }
    }
}