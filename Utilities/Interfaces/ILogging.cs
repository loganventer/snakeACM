namespace Snake.Utilities.Interfaces
{
    public interface ILogging
    {
        void SetDebugEnabled(bool enabled);
        void Log(string logString);
    }
}