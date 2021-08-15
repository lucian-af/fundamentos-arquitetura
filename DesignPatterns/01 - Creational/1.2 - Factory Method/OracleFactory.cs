namespace DesignPatterns.Factory.Method
{
    public class OracleFactory : DbFactory
    {
        // Factory Method
        public override DbConnector CreateConnector(string connectionString)
            => new OracleConnector(connectionString);
    }
}
