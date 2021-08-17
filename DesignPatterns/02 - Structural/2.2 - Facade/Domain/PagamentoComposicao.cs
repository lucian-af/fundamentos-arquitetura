namespace DesignPatterns.Facade.Domain
{
    public class PagamentoComposicao
    {
        public Pagamento Pagamento { get; set; }
        public string CartaoCredito { get; set; }
        public string LinhaDigitavelBoleto { get; set; }
        public string ConfirmacaoTransferencia { get; set; }
    }
}
