namespace SOLID.OCP.Solucao
{
    public class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Debita conta invenstimento
            return FormatarTransacao();
        }
    }
}
