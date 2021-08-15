namespace Desenvolvedor.IO.DI.Cases
{
    /// <summary>
    /// Esse tipo de implementação viola no mínimo um princípio do SOLID, o LSP
    /// pois muitas classas são um IService.
    /// Sem contar que obriga o uso do anti-pattern ServiceLocator
    /// </summary>
    public interface IService
    {
        string Retorno();
    }

    public class ServiceA : IService
    {
        public string Retorno()
        {
            return "A";
        }
    }
    public class ServiceB : IService
    {
        public string Retorno()
        {
            return "B";
        }
    }
    public class ServiceC : IService
    {
        public string Retorno()
        {
            return "C";
        }
    }
}
