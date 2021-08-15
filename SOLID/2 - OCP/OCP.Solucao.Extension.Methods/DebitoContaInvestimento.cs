namespace SOLID.OCP.Solucao.Extension.Methods
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            // Debita conta invstimento
            return debitoConta.FormatarTransacao();
        }
    }
}
