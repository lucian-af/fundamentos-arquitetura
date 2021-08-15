namespace OOP
{
    /// <summary>
    /// Classes abstratas servem de base para especializações (superclasses)
    /// classe abstrata não pode ser instanciada
    /// </summary>
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;

        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        /// <summary>
        /// Método abstrato não possui implementação, somente assinatura
        /// a implementação é feita nas classes que implementem a classe abstrata
        /// </summary>
        public abstract void Ligar();
        public abstract void Desligar();

        /// <summary>
        /// o modificador "virtual" define que o método possui uma implementação na sua criação
        /// mas oferece a possibilidade de sobrescrita para as classes que herdarem da abstração
        /// </summary>
        public virtual void Testar()
        {
            // teste do equipamento
        }
    }
}
