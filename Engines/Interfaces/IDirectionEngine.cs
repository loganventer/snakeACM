using Snake.Engines.Enumerations;

namespace Snake.Engines.Interfaces
{
    public interface IDirectionEngine
    {
        void TurnLeft();
        void TurnRight();
        void TurnDown();
        void TurnUp();
        Direction GetDirection();
    }
}