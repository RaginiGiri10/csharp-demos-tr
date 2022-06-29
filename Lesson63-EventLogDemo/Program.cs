using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson63_EventLogDemo
{
   
    class Program
    {
        static void Main(string[] args)
        {
           
        
            try
            {
                int firstNumber = 10;
                int secondNumber = 0;
                Console.WriteLine(firstNumber / secondNumber);
            }
            catch(Exception ex)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Application";
                    eventLog.WriteEntry(ex.Message, EventLogEntryType.Error);

                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadLine();

        }
    }
}
