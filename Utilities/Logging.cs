using System;
using Snake.Utilities.Interfaces;

namespace Snake.Utilities
{
    public class Logging : ILogging
    {
        public void Log(string logString)
        {
            Console.WriteLine(logString);
        }
    }
}