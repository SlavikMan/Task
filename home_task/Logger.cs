using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace home_task
{
    public static class Logger
    {
        public static void WriteLog(string message)
        {
            string logPath = ConfigurationManager.AppSettings["logPath"];

            using (StreamWriter writer = new StreamWriter(logPath , true))
            {
                writer.WriteLine($"{DateTime.Now} : {message}");
            }
        }
    }
}
