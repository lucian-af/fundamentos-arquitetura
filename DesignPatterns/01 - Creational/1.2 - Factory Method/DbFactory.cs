using System;

namespace DesignPatterns.Factory.Method
{
    // Abstract creator
    // a classe em si não é uma factory, o método que ela implementa que é a fábrica
    public abstract class DbFactory
    {
        // Método que dá sentido à aplicação do pattern
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory Database(DataBase database) => database switch
        {
            DataBase.SqlServer => new SqlServerFactory(),
            DataBase.Oracle => new OracleFactory(),
            DataBase.PostgreSql => new PostgreSqlFactory(),
            _ => throw new ApplicationException("Banco de dados não reconhecido.")
        };
    }
}
