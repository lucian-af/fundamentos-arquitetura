namespace DesignPatterns.Factory.Method
{
    // Concrete Creator
    public class SqlServerFactory : DbFactory
    {
        // Factory Method
        public override DbConnector CreateConnector(string connectionString)
            => new SqlServerConnector(connectionString);
    }
}
