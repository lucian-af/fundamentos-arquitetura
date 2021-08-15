namespace DesignPatterns.Adapter
{
    public class ExecutarAdapter
    {
        public static void Executar()
        {
            var pagamentoLogPadrao = new TransacaoService(new Logger());
            pagamentoLogPadrao.RealizarTransacao();

            var pagamentoLogPersonalizado = new TransacaoService(new LogAdapter(new LoggerDiferenteService()));
            pagamentoLogPersonalizado.RealizarTransacao();
        }
    }
}
