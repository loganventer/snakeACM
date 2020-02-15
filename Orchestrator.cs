using System;
using Snake.Interfaces;
using Snake.Managers.Interfaces;
using Snake.Utilities.Interfaces;

namespace Snake
{
    public class Orchestrator : IOrchestrator
    {
        const int FrameTime = 1000;
        private readonly ISnakeManager _snakeManager = null;
        private readonly IGridManager _gridManager = null;
        private readonly IScoreManager _scoreManager = null;
        private readonly ILogging _logging;
        private TimeSpan _frameTime = TimeSpan.Zero;
        private DateTime _previousDateTime = DateTime.Now;
        int count = 0;

        public Orchestrator(
            ISnakeManager snakeManager,
            IGridManager gridManager,
            IScoreManager scoreManager,
            ILogging logging)
        {
            _snakeManager = snakeManager;
            _gridManager = gridManager;
            _scoreManager = scoreManager;
            _logging = logging;
            //TODO: Configuration
            logging.SetDebugEnabled(true);
        }

        public void RunOnce(ConsoleKey consoleKey)
        {
            if(consoleKey!= ConsoleKey.NoName)
            {
                _snakeManager.RunOnce(consoleKey);
                _logging.Log($"Ran {count} next frame {_frameTime.TotalMilliseconds}, key: {consoleKey.ToString()}");
            }

            var dtNow = DateTime.Now;

            _frameTime = dtNow - _previousDateTime;
            
            if(_frameTime.TotalMilliseconds <= FrameTime)
            {
                return;
            }

            _previousDateTime = dtNow;
            _frameTime = TimeSpan.FromMilliseconds(_frameTime.TotalMilliseconds - FrameTime);
            count++;
            _logging.Log($"Ran {count} next frame {_frameTime.TotalMilliseconds}, key: {consoleKey.ToString()}");
        }
    }
}