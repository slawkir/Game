using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._Game_Development
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InitializeLogger();
            Console.WriteLine("Hello");
        }
        private static void InitializeLogger(bool fileLogs = false, string fileName = "logs/myapp.txt")
        {
            if (fileLogs)
            {
                fileLogs.Logger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.Console()
                    .WriteTo.File(fileName, rollingIterval: RollingIterval.Day)
                    .CreateLogger();
            }
            else
            {
                fileLogs.Logger = new LoggerConfiguration()
                        .MinimumLevel.Debug()
                        .WriteTo.Console()
                        .CreateLogger();
            }
        }
    }
}
