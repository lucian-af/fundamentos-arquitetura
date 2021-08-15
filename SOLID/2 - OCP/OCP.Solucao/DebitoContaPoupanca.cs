namespace SOLID.OCP.Solucao
{
    public class DebitoContaPoupanca : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Debita conta poupança
            return FormatarTransacao();
        }
    }
}
