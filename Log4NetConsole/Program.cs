using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            log.Error("error");
            log.Fatal("fatal");
            log.Info("info");
            log.Debug("debug");
            log.Warn("warn");
            Console.WriteLine("日志记录完毕。");
            Console.Read();
        }
    }
}
