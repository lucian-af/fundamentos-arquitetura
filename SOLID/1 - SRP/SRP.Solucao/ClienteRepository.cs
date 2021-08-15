using System.Data;
using System.Data.SqlClient;

namespace SOLID.SRP.Solucao
{
    public class ClienteRepository
    {
        public void Adicionar(Cliente cliente)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) VALUES (@NOME, @EMAIL, @CPF, @DATACAD)";

                cmd.Parameters.AddWithValue("NOME", cliente.Nome);
                cmd.Parameters.AddWithValue("EMAIL", cliente.Email);
                cmd.Parameters.AddWithValue("CPF", cliente.Cpf);
                cmd.Parameters.AddWithValue("DATACAD", cliente.DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
