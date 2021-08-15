using System;

namespace DesignPatterns.Factory.Method
{
    public class SqlServerConnector : DbConnector
    {
        public SqlServerConnector(string connectionString) : base(connectionString) { }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco Sql Server...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
