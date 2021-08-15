using System;

namespace OOP
{
    /// <summary>
    /// A classe que está herdando sempre é um tipo da classe que é herdada
    /// Funcionário é uma Pessoa
    /// se não fizer sentido o "é um", talvez não deva ser herdado.
    /// </summary>
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo
    {
        /// <summary>
        /// Por herdar de pessoa, funcionario assume os atributos da classe pessoa
        /// </summary>
        public void Execucao()
        {
            var funcionario = new Funcionario
            {
                Nome = "João dos Santos",
                DataNascimento = Convert.ToDateTime("1960/05/14"),
                DataAdmissao = Convert.ToDateTime("2003/10/16"),
                Registro = "0123456"
            };
        }
    }
}
