using System.Data;
using System.Data.SqlClient;
using SOLID.DIP.Solucao.Interfaces;

namespace SOLID.DIP.Solucao
{
    public class ClienteRepository : IClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
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
