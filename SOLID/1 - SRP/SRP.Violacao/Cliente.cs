using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID.SRP.Violacao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public string AdicionarCliente()
        {
            if (!Email.Contains("@"))
                return "Cliente com e-mail inválido";

            if (Cpf.Length != 11)
                return "Cliente com CPF inválido";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) VALUES (@NOME, @EMAIL, @CPF, @DATACAD)";

                cmd.Parameters.AddWithValue("NOME", Nome);
                cmd.Parameters.AddWithValue("EMAIL", Email);
                cmd.Parameters.AddWithValue("CPF", Cpf);
                cmd.Parameters.AddWithValue("DATACAD", DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var mail = new MailMessage("empresa@empresa.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Bem vindo";
            mail.Body = "Parabéns! Você está cadastrado.";
            client.Send(mail);

            return "Cliente cadastrado com sucesso!";
        }
    }
}
