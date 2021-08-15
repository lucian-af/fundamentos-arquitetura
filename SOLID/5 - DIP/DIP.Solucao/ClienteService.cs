using SOLID.DIP.Solucao.Interfaces;

namespace SOLID.DIP.Solucao
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repoCliente;
        private readonly IEmailService _emailService;

        public ClienteService(
            IClienteRepository repoCliente,
            IEmailService emailService)
        {
            _repoCliente = repoCliente;
            _emailService = emailService;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            _repoCliente.AdicionarCliente(cliente);

            _emailService.EnviarEmail(
                "empresa@empresa.com.br",
                cliente.Email.Endereco,
                "Bem vindo",
                "Parabéns, você foi cadastrado.");

            return "Cliente cadastrado com sucesso!";
        }

    }
}
