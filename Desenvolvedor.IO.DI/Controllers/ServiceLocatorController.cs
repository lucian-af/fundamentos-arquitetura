using System;
using Desenvolvedor.IO.DI.Cases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Desenvolvedor.IO.DI.Controllers
{
    /// <summary>
    /// ServiceLocator é considerado um anti-pattern, facilita a resolução de alguns casos
    /// mas pode trazer mais problema do que ajudar, fora que dificulta muito os testes unitários.
    /// Pattern não recomendado.
    /// </summary>
    public class ServiceLocatorController : Controller
    {
        private readonly IServiceProvider _serviceProvider;

        public ServiceLocatorController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Index()
        {
            // Retorna null se não estiver registrado
            _serviceProvider.GetRequiredService<IClienteServices>().AdicionarCliente(new Cliente());
        }
    }
}
