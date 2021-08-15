namespace SOLID.OCP.Solucao.Extension.Methods
{
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            // Debita conta corrente
            return debitoConta.FormatarTransacao();
        }
    }
}
