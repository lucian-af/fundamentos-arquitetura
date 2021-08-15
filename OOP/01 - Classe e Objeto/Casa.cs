namespace OOP
{
    /// <summary>
    /// Definição de classe
    /// Estrutura de código que define algo que exista no mundo real
    /// </summary>
    public class Casa
    {
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas { get; set; }
    }

    public class Objeto
    {
        /// <summary>
        /// Algo que existe na memória do computador, a partir do momento que instanciamos uma classe
        /// ela passa a ser um objeto na memória do computador
        /// </summary>
        public Objeto()
        {
            var casa = new Casa
            {
                TamanhoM2 = 100,
                Andares = 2,
                Valor = 100000,
                NumeroVagas = 3
            };
        }
    }

}
