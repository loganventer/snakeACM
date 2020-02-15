using Snake.Engines.Interfaces;
using Snake.Engines.Enumerations;

namespace Snake.Engines
{
    public class DirectionEngine : IDirectionEngine
    {
        private Direction direction = Direction.Right;
        public void TurnDown()
        {
            if (direction != Direction.Up)
                direction = Direction.Down;
        }

        public void TurnLeft()
        {
            if (direction != Direction.Right)
                direction = Direction.Left;
        }

        public void TurnRight()
        {
            if (direction != Direction.Left)
                direction = Direction.Right;
        }

        public void TurnUp()
        {
            if (direction != Direction.Down)
                direction = Direction.Up;
        }
    }
}