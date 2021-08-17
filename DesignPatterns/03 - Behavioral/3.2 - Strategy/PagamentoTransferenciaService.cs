using System;
using System.Linq;
using DesignPatterns.Facade.Domain;
using DesignPatterns.Facade.Domain.Interface;

namespace DesignPatterns.Behavioral.Strategy
{
    public class PagamentoTransferenciaService : IPagamento
    {
        private readonly IPagamentoTransferenciaFacade _pagamentoTransferenciaFacade;

        public PagamentoTransferenciaService(IPagamentoTransferenciaFacade pagamentoTransferenciaFacade)
        {
            _pagamentoTransferenciaFacade = pagamentoTransferenciaFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine("Iniciando Pagamento via Transferência - Valor R$ " + pagamento.Valor);

            pagamento.PagamentoComposicao.ConfirmacaoTransferencia = _pagamentoTransferenciaFacade.RealizarTransferencia();
            pagamento.Status = "Pago via Transferência";
            return pagamento;
        }
    }
}
