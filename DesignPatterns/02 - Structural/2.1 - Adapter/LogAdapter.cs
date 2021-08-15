using System;

namespace DesignPatterns.Adapter
{
    // Adapter class
    public class LogAdapter : ILogger
    {
        private readonly ILoggerDiferente _logPersonalizado;

        public LogAdapter(ILoggerDiferente logPersonalizado)
        {
            _logPersonalizado = logPersonalizado;
        }

        public void Log(string mensagem)
        {
            _logPersonalizado.LogInfo(mensagem);
        }

        public void LogError(Exception exception)
        {
            _logPersonalizado.LogException(new ExceptionPersonalized(exception));
        }
    }
}
