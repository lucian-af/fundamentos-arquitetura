namespace DesignPatterns.Factory.Method
{
    public class PostgreSqlFactory : DbFactory
    {
        // Factory Method
        public override DbConnector CreateConnector(string connectionString)
            => new PostgreSqlConnector(connectionString);
    }
}
