using System;
using Desenvolvedor.IO.DI.Cases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Desenvolvedor.IO.DI.Controllers
{
    public class ServiceLocator2Controller : Controller
    {
        public void Index([FromServices] IServiceProvider serviceProvider)
        {
            // Retorna null se não estiver registrado
            var clienteService = serviceProvider.GetRequiredService<IClienteServices>();
            clienteService.AdicionarCliente(new Cliente());
        }
    }
}
