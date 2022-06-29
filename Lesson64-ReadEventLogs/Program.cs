using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson64_ReadEventLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            using(EventLog eventLog = new EventLog("Application"))
            {
                foreach(EventLogEntry entry in eventLog.Entries)
                {
                    Console.WriteLine($"Entry - {entry.Message}");
                }
            }

            Console.Read();
        }
    }
}
