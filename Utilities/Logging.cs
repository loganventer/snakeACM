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
                var mth = new StackTrace().GetFrame(1).GetMethod();
                var cls = mth.ReflectedType.Name;
                Console.WriteLine(logString);
            }
        }

        public void SetDebugEnabled(bool enabled)
        {
            _debugEnabled = enabled;
        }
    }
}