using System;

namespace DesignPatterns.Factory.Method
{
    public class Connection
    {
        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; private set; }

        public bool Opened { get; private set; }

        public void Open()
        {
            Opened = true;
            Console.WriteLine("Conexão aberta.");
        }

        public void Close()
        {
            Opened = false;
            Console.WriteLine("Conexão fechada.");
        }

        public void ExecuteCommand(string command)
        {
            if (Opened)
                Console.WriteLine($"Executando comando: {command}");
            else
                throw new ApplicationException("Conexão com o banco fechada.");
        }
    }
}
