using System;

namespace Snake.Interfaces
{
    public interface IOrchestrator
    {
         void RunOnce(ConsoleKey consoleKey);
    }
}