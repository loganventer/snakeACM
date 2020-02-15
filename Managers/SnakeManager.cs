using System;
using Snake.Engines.Interfaces;
using Snake.Managers.Interfaces;
using Snake.Utilities.Interfaces;

namespace Snake.Managers
{
    public class SnakeManager : ISnakeManager
    {
        private readonly IDirectionEngine _directionEngine;
        private readonly ILogging _logging;

        public SnakeManager(
            IDirectionEngine directionEngine,
            ILogging logging)
        {
            _logging = logging;
            _directionEngine = directionEngine;
            logging.SetDebugEnabled(true);
        }
        public void RunOnce(ConsoleKey consoleKey)
        {
            if (consoleKey != ConsoleKey.NoName)
            {
                _logging.Log($"Turning {consoleKey}");
                switch (consoleKey)
                {
                    case ConsoleKey.DownArrow:
                        {
                            _directionEngine.TurnDown();
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            _directionEngine.TurnUp();
                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        {
                            _directionEngine.TurnLeft();
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            _directionEngine.TurnRight();
                            break;
                        }
                }
            }
        }
    }
}