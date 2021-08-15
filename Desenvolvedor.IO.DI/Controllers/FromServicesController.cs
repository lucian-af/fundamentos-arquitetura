using Desenvolvedor.IO.DI.Cases;
using Microsoft.AspNetCore.Mvc;

namespace Desenvolvedor.IO.DI.Controllers
{
    public class FromServicesController : Controller
    {
        public void Index([FromServices] IClienteServices clienteServices)
        {
            clienteServices.AdicionarCliente(new Cliente());
        }
    }
}
