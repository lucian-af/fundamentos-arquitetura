using System;

namespace DesignPatterns.Adapter
{
    // Adaptee class
    // classe de adaptação do Log
    public class LoggerDiferenteService : ILoggerDiferente
    {
        public void LogException(ExceptionPersonalized exception)
        {
            Console.WriteLine($"Log personalizado: Mensagem: {exception.Message} " +
                $"| StackTrace: {exception.StackTrace} " +
                $"| InnerException: {exception.InnerException}");
        }

        public void LogInfo(string mensagem) => Console.WriteLine($"Log personalizado: {mensagem}");
    }
}
