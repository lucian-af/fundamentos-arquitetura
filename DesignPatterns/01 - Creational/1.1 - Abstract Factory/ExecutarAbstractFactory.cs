using System.Collections.Generic;

namespace DesignPatterns.Abstract.Factory
{
    public class ExecutarAbstractFactory
    {

        public static void Executar()
        {
            var veiculoSocorro = new List<Veiculo>
            {
                VeiculoCreator.Criar("Fiat Pálio", Porte.Pequeno),
                VeiculoCreator.Criar("GM-Chevrolet Monza", Porte.Medio),
                VeiculoCreator.Criar("BMW X6", Porte.Grande),
            };

            veiculoSocorro.ForEach(v => AutoSocorro.CriarAutoSocorro(v).RealizarAtendimento());
        }
    }
}
