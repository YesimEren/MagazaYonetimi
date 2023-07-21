using BusinessLayer;
using DataAccess.DAL;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ILogger = Serilog.ILogger;

namespace Logger
{
    public class LoggerService:ILoggerService

    {
        private readonly ILogger logger;

        public LoggerService()
        {
          
            logger = new LoggerConfiguration()
                .WriteTo.Console() 
                .CreateLogger();
        }
        public void LogInformation(string message)
        {
            logger.Information("Bu bilgi mesajıdır.");
        }

        public void LogWarning(string message)
        {
            logger.Warning("Uyarı");
        }

        public void LogError(string message)
        {
            logger.Error("Hatalı işlem yaptınız.");
        }
    }

   
}
