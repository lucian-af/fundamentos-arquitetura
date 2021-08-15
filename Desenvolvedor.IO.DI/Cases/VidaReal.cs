using System;

namespace Desenvolvedor.IO.DI.Cases
{
    public class Cliente
    {
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataHoraCadastro { get; set; }
    }

    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);
    }

    public class ClienteRepository : IClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }

    public interface IClienteServices
    {
        void AdicionarCliente(Cliente cliente);
    }

    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteServices(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _clienteRepository.AdicionarCliente(cliente);
        }
    }
}
