using System;

namespace DesignPatterns.Factory.Method
{
    public class ExecutarFactoryMethod
    {
        public static void Executar()
        {
            ConectarSqlServer();

            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("");

            ConectarOracle();

            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("");

            ConectarPostgreSql();
        }

        private static void ConectarPostgreSql()
        {
            var postgreSqlCn = DbFactory.Database(DataBase.PostgreSql)
                            .CreateConnector("connectionStringPostgreSql")
                            .Connect();

            postgreSqlCn.ExecuteCommand("select * from tabelaPostgreSql");
            postgreSqlCn.Close();
        }

        private static void ConectarOracle()
        {
            var oracleCn = DbFactory.Database(DataBase.Oracle)
                            .CreateConnector("connectionStringOracle")
                            .Connect();

            oracleCn.ExecuteCommand("select * from tabelaOracle");
            oracleCn.Close();
        }

        private static void ConectarSqlServer()
        {
            var sqlServerCn = DbFactory.Database(DataBase.SqlServer)
                .CreateConnector("connectionStringSqlServer")
                .Connect();

            sqlServerCn.ExecuteCommand("select * from tabelaSqlServer");
            sqlServerCn.Close();
        }
    }
}
