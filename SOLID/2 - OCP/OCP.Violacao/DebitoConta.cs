namespace SOLID.OCP.Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            {
                // débito conta corrente
            }

            if (tipoConta == TipoConta.Poupanca)
            {
                // validar aniversário da conta
                // débito conta poupanca
            }
        }
    }
}
