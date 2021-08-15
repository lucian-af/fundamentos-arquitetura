namespace OOP
{
    /// <summary>
    /// Poli-morfismo: múltiplos comportamentos
    /// o uso de polimorfismo permite que a classe abstrata tenha diversos comportamentos
    /// com base na classe que a esteja implementando
    /// </summary>
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem)
            : base(nome, voltagem)
        {

        }

        public CafeteiraEspressa() : base("Padrão", 220) { }

        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
            // ...
        }

        /// <summary>
        /// Permitido a sobrescrita pelo fato do método ter o modificador "virtual" na classe base
        /// </summary>
        public override void Testar()
        {
            // teste da cafeteira
        }

        /// <summary>
        /// Override - sobrescrever método da classe abstrata
        /// </summary>
        public override void Ligar()
        {
            // Verificar recipiente de água
        }

        public override void Desligar()
        {
            // Resfriar aquecedor
        }

    }
}
