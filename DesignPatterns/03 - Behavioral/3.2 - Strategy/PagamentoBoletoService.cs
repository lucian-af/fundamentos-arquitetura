using System;
using System.Linq;
using DesignPatterns.Facade.Domain;
using DesignPatterns.Facade.Domain.Interface;

namespace DesignPatterns.Behavioral.Strategy
{
    public class PagamentoBoletoService : IPagamento
    {
        private readonly IPagamentoBoletoFacade _pagamentoBoletoFacade;

        public PagamentoBoletoService(IPagamentoBoletoFacade pagamentoBoletoFacade)
        {
            _pagamentoBoletoFacade = pagamentoBoletoFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine("Iniciando Pagamento via Boleto - Valor R$ " + pagamento.Valor);


            pagamento.PagamentoComposicao.LinhaDigitavelBoleto = _pagamentoBoletoFacade.GerarBoleto();
            pagamento.Status = "Aguardando Pagamento";
            return pagamento;
        }
    }
}
