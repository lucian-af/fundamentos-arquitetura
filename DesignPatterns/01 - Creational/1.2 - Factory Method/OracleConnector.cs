using System;

namespace DesignPatterns.Factory.Method
{
    // Classe concreta do produto
    public class OracleConnector : DbConnector
    {
        public OracleConnector(string connectionString) : base(connectionString) { }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco Oracle...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
