using DesignPatterns.Facade.Domain;
using DesignPatterns.Facade.Domain.Interface;

namespace DesignPatterns.Behavioral.Strategy
{
    public class PedidoService
    {
        public readonly IPagamento _pagamento;

        public PedidoService(IPagamento pagamento)
            => _pagamento = pagamento;

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
         => _pagamento.RealizarPagamento(pedido, pagamento);
    }
}
