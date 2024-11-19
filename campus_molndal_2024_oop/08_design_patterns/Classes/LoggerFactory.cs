using campus_molndal_2024_oop._08_design_patterns.Interfaces;
using System;

namespace campus_molndal_2024_oop._08_design_patterns.Classes
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging to a file: " + message);
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging to console: " + message);
        }
    }

    public sealed class LoggerFactory
    {
        private static LoggerFactory instance;

        private LoggerFactory() { }

        public static LoggerFactory GetInstance()
        {
            if (instance == null)
            {
                instance = new LoggerFactory();
            }
            return instance;
        }

        public ILogger CreateLogger(string type)
        {
            if (type.Equals("File", StringComparison.OrdinalIgnoreCase))
            {
                return new FileLogger();
            }
            else if (type.Equals("Console", StringComparison.OrdinalIgnoreCase))
            {
                return new ConsoleLogger();
            }
            return null;
        }
    }
}
