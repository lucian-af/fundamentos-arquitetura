using DesignPatterns.Facade.Domain.Enum;

namespace DesignPatterns.Facade.Domain
{
    public class Pagamento
    {
        public string Status { get; set; }
        public decimal Valor { get; set; }
        public MeioPagamento MeioPagamento { get; set; }
        public virtual PagamentoComposicao PagamentoComposicao { get; set; }
    }
}
