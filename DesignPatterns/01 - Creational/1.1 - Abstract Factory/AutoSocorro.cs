using System;

namespace DesignPatterns.Abstract.Factory
{
    // Classe Client, classe que faz uso da fábrica
    public class AutoSocorro
    {
        private readonly Veiculo _veiculo;
        private readonly Guincho _guincho;

        public AutoSocorro(AutoSocorroFactory factory, Veiculo veiculo)
        {
            _veiculo = factory.CriarVeiculo(veiculo.Modelo, veiculo.Porte);
            _guincho = factory.CriarGuincho();
        }

        public void RealizarAtendimento()
        {
            _guincho.Socorrer(_veiculo);
        }

        public static AutoSocorro CriarAutoSocorro(Veiculo veiculo) => veiculo.Porte switch
        {
            Porte.Pequeno => new AutoSocorro(new SocorroVeiculoPequenoFactory(), veiculo),
            Porte.Medio => new AutoSocorro(new SocorroVeiculoMedioFactory(), veiculo),
            Porte.Grande => new AutoSocorro(new SocorroVeiculoGrandeFactory(), veiculo),
            _ => throw new ApplicationException("Não foi possível identificar o veículo.")
        };
    }
}
