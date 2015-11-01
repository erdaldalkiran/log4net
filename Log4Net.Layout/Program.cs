using System;
using System.Security.Principal;
using log4net;

namespace Log4Net.Layout
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            var logger = LogManager.GetLogger(typeof (Program));

            logger.Debug("Debug");

            try
            {
                throw new ArgumentNullException("me");
            }
            catch (Exception ex)
            {
                logger.ErrorFormat("{0} olmadi yar!", WindowsIdentity.GetCurrent().Name);
                logger.Error("Exception: ", ex);
            }

            Console.ReadKey();
        }
    }
}