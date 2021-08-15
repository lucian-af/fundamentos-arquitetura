using System;

namespace DesignPatterns.Adapter
{
    public class Logger : ILogger
    {
        public void Log(string mensagem) => Console.WriteLine($"Log padrão - {mensagem}");

        public void LogError(Exception exception) => Console.WriteLine($"Log padrão - {exception.Message}");
    }
}
