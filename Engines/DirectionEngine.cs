using Snake.Engines.Interfaces;
using Snake.Engines.Enumerations;
using Snake.Utilities.Interfaces;

namespace Snake.Engines
{
    public class DirectionEngine : IDirectionEngine
    {
        private readonly ILogging _logging;

        public DirectionEngine(ILogging logging)
        {
            _logging = logging;
            logging.SetDebugEnabled(true);

        }
        private Direction direction = Direction.Right;
        public void TurnDown()
        {
            if (direction != Direction.Up)
            {
                _logging.Log("Turning Down");
                direction = Direction.Down;
            }
        }

        public void TurnLeft()
        {
            if (direction != Direction.Right)
            {
                _logging.Log("Turning Left");
                direction = Direction.Left;
            }
        }

        public void TurnRight()
        {
            if (direction != Direction.Left)
            {
                _logging.Log("Turning Right");
                direction = Direction.Right;
            }
        }

        public void TurnUp()
        {
            if (direction != Direction.Down)
            {
                direction = Direction.Up;
                _logging.Log("Turning Up");
            }
        }

        public Direction GetDirection()
        {
            return direction;
        }
    }
}