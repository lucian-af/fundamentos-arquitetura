using System;

namespace OOP
{
    #region Caso 1
    /// <summary>
    /// Herança
    /// </summary>
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
    }


    /// <summary>
    /// Composição
    /// </summary>
    public class PessoaFisica2
    {
        public Pessoa Pessoa { get; set; }
        public string Cpf { get; set; }
    }

    public class TesteHerancaComposicao
    {
        public TesteHerancaComposicao()
        {
            var pessoaHeranca = new PessoaFisica
            {
                Nome = "Joao",
                DataNascimento = DateTime.Now,
                Cpf = "12145478701"
            };

            var pessoaComposicao = new PessoaFisica2
            {
                Pessoa = new Pessoa
                {
                    Nome = "Jose",
                    DataNascimento = DateTime.Now
                },
                Cpf = "32356587811"
            };

            var nomeHeranca = pessoaHeranca.Nome;
            var nomeComposicao = pessoaComposicao.Pessoa.Nome;
        }
    }
    #endregion

    #region Caso 2
    /// <summary>
    /// interface genérica onde T pode ser qualquer classe
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepositorio<T> where T : class
    {
        void Adicionar(T obj);
        void Excluir(T obj);
    }


    /// <summary>
    /// interface especializada para o tipo Pessoa
    /// </summary>
    public interface IRepositorioPessoa
    {
        void Adicionar(Pessoa obj);
    }

    /// <summary>
    /// Repositorio genérico onde T pode ser qualquer classe que implementa uma interface generica
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        public void Adicionar(T obj)
        {
            // adicionar classe generica
        }

        public void Excluir(T obj)
        {
            // excluir classe generica
        }
    }

    /// <summary>
    /// exemplo de Herança, repositorio herda de um repositorio genérico especializando para usar o tipo Pessoa
    /// risco maior de alto acoplamento
    /// </summary>
    public class RepositorioHerancaPessoa : Repositorio<Pessoa>, IRepositorioPessoa
    {
        // nesse exemplo de herança, podemos acabar expondo métodos que não deveriam ser expostos
        // pra esse caso, expomos o método Excluir, pelo uso de herança do repositorio genérico
        // uma vez que a interface IRepositorioPessoa em seu contrato exige apenas o método Adicionar
    }

    /// <summary>
    /// exemplo de composição, exemplo com baixo acoplamento, or mais que esteja herdando, 
    /// está herdando de uma abstração e não de uma classe concreta.
    /// e também só expõe aquilo que a interface permite não expõe métodos não permitidos como o caso da herança
    /// </summary>
    public class RepositorioComposicaoPessoa : IRepositorioPessoa
    {
        private readonly IRepositorio<Pessoa> _repositorioPessoa;

        public RepositorioComposicaoPessoa(IRepositorio<Pessoa> repositorioPessoa)
        {
            _repositorioPessoa = repositorioPessoa;
        }

        public void Adicionar(Pessoa obj)
        {
            _repositorioPessoa.Adicionar(obj);
        }
    }

    public class TesteHerancaComposicao2
    {
        public TesteHerancaComposicao2()
        {
            var repoHeranca = new RepositorioHerancaPessoa();
            repoHeranca.Adicionar(new Pessoa());
            repoHeranca.Excluir(new Pessoa());

            var repoComposicao = new RepositorioComposicaoPessoa(new Repositorio<Pessoa>());
            repoComposicao.Adicionar(new Pessoa());
        }
    }
    #endregion
}
