using System;
using System.Diagnostics;
using Snake.Utilities.Interfaces;

namespace Snake.Utilities
{
    public class Logging : ILogging
    {
        private bool _debugEnabled = false;
        public void Log(string logString)
        {
            if (_debugEnabled)
            {
                var method = new StackTrace().GetFrame(1).GetMethod();
                var typeName = method.ReflectedType.Name;
                Console.WriteLine($"[{typeName}] {logString}");
            }
        }

        public void SetDebugEnabled(bool enabled)
        {
            _debugEnabled = enabled;
        }
    }
}