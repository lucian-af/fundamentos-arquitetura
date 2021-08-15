using System;

namespace DesignPatterns.Factory.Method
{
    public class PostgreSqlConnector : DbConnector
    {
        public PostgreSqlConnector(string connectionString) : base(connectionString) { }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco PostgreSql...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
