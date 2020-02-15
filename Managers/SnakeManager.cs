using System;
using Snake.Engines.Interfaces;
using Snake.Managers.Interfaces;
namespace Snake.Managers
{
    public class SnakeManager : ISnakeManager
    {
        private readonly IDirectionEngine _directionEngine;

        public SnakeManager(IDirectionEngine directionEngine)
        {
            _directionEngine = directionEngine;
        }
        public void RunOnce(ConsoleKey consoleKey)
        {
            if (consoleKey != ConsoleKey.NoName)
            {
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