using System;

namespace DesignPatterns.Adapter
{
    public interface ILogger
    {
        void Log(string mensagem);
        void LogError(Exception exception);
    }
}
