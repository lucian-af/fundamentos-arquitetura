namespace DesignPatterns.Factory.Method
{
    // Abstract Produto
    // Essa clase serve de base para qualquer conector (SqlServer, Oracle, PostgreSql)
    public abstract class DbConnector
    {
        protected DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; private set; }

        public abstract Connection Connect();
    }
}
