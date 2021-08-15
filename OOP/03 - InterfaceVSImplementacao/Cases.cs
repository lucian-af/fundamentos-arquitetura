namespace OOP
{
    /// <summary>
    /// Interfaces são uma espécie de contrato, que é firmado entre a classe que a implementa
    /// </summary>
    public interface IRepositorio
    {
        void Adicionar();
    }

    /// <summary>
    /// a classe que implementa a interface é obrigada a seguir as "cláusulas" do contrato
    /// ou seja, tudo que a interface exige de implementação deve ser seguido a risca
    /// </summary>
    public class Repositorio : IRepositorio
    {
        public void Adicionar()
        {
            // Adicionar
        }
    }

    /// <summary>
    /// a ideia é para cenários de teste, ele só vai simular as regras da interface
    /// </summary>
    public class RepositorioFake : IRepositorio
    {
        public void Adicionar()
        {
            // adicionar fake
        }
    }

    /// <summary>
    /// Existe a possibilidade de um forte acoplamento no uso de implementação
    /// </summary>
    public class UsoImplementacao
    {
        /// <summary>
        /// exemplo de implementação, é necessário saber como instanciar a classe para que funcione o processo
        /// esse é um exemplo do princípio do acoplamento
        /// se por algum motivo a classe repositorio mudar, o seu construtor for modificado, vai quebrar em todos os
        /// lugares que estiverem instanciando a classe repositorio
        /// </summary>
        public void Processo()
        {
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }

    /// <summary>
    /// Mesmo exemplo anterior, porém usando abstração, a classe não precisa saber como instanciar o repositorio
    /// pois ela depende da interface e não da classe concreta, se a classe concreta mudar não vai afetar a abstração
    /// </summary>
    public class UsoAbstracao
    {
        private readonly IRepositorio _repositorio;

        public UsoAbstracao(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            _repositorio.Adicionar();
        }
    }
    public class TesteInterfaceImplementacao
    {
        public TesteInterfaceImplementacao()
        {
            var repoImp = new UsoImplementacao();
            repoImp.Processo();

            var repoAbs = new UsoAbstracao(new Repositorio());
            repoAbs.Processo();

            var repoAbsFake = new UsoAbstracao(new RepositorioFake());
            repoAbsFake.Processo();
        }
    }
}
