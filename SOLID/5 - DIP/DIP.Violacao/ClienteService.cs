namespace SOLID.DIP.Violacao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.Adicionar(cliente);

            EmailService.Enviar(
                "empresa@empresa.com.br",
                cliente.Email.Endereco,
                "Bem vindo",
                "Parabéns, você foi cadastrado.");

            return "Cliente cadastrado com sucesso!";
        }
    }
}
