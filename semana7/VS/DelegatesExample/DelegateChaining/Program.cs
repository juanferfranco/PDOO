using System;
using System.IO;

namespace DelegateChaining
{
    public delegate void LogEventHandler(LogEvent logEvent);

    class Program
    {
        static void Main(string[] args)
        {
            LogEventHandler logHandlers = LogToConsole;
            logHandlers += LogToFile;
            logHandlers(new LogEvent("Message"));
            logHandlers -= LogToFile;
            logHandlers(new LogEvent("Message2"));


            Console.ReadKey();
        }
      
        private static void LogToConsole(LogEvent logEvent)
        {
            Console.WriteLine(logEvent.Text);
        }

        private static void LogToFile(LogEvent logEvent)
        {
            File.AppendAllText("log.txt", logEvent.Text + Environment.NewLine);
        }
    }

}
