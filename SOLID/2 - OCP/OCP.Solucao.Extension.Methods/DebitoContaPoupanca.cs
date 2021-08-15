namespace SOLID.OCP.Solucao.Extension.Methods
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta)
        {
            // Debita conta poupanca
            return debitoConta.FormatarTransacao();
        }
    }
}
