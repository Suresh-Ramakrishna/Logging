using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch =true)]
namespace CSharpLogging
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            GlobalContext.Properties["SomeExtraDataToDisplay"] = 10;
            log.Debug("Hello World!");
            Console.ReadKey();
        }
    }
}
