namespace OOP
{
    /// <summary>
    /// Encapsulamento: esconder comportamentos e expor outros em alto nível que faça uso dos comportamentos ocultos
    /// EX: automação não sabe como preparar o café, mas faz uso de métodos que preparam o café.
    /// Outra definição de encapsulamento é: fazer uso de métodos que não temos conhecimento de como funcionam.
    /// </summary>
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var espresso = new CafeteiraEspressa();
            espresso.Ligar();
            espresso.PrepararCafe();
            espresso.Desligar();
        }
    }
}
