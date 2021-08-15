using System;

namespace DesignPatterns.Adapter
{
    public interface ILoggerDiferente
    {
        void LogInfo(string mensagem);
        void LogException(ExceptionPersonalized exception);
    }

    public class ExceptionPersonalized : Exception
    {
        public ExceptionPersonalized(string mensagem) : base(message: mensagem) { }
        public ExceptionPersonalized(Exception innerException)
            : base(message: null, innerException: innerException) { }
    }
}
