using System;

namespace DesignPatterns.Abstract.Factory
{
    public abstract class Guincho
    {
        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);
        public Porte Porte { get; private set; }
    }

    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Aqui ficaria a lógica de negócio, podemos ter lógicas diferentes porte de veiculo
            // Daqui podemos ir pra uma fila, pra armazenamento em banco, etc
            Console.WriteLine($"Socorrendo Carro Pequeno - Modelo {veiculo.Modelo}");
        }
    }
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Aqui ficaria a lógica de negócio, podemos ter lógicas diferentes porte de veiculo
            // Daqui podemos ir pra uma fila, pra armazenamento em banco, etc
            Console.WriteLine($"Socorrendo Carro Medio - Modelo {veiculo.Modelo}");
        }
    }

    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            // Aqui ficaria a lógica de negócio, podemos ter lógicas diferentes porte de veiculo
            // Daqui podemos ir pra uma fila, pra armazenamento em banco, etc
            Console.WriteLine($"Socorrendo Carro Grande - Modelo {veiculo.Modelo}");
        }
    }

    public class GuinchoCreator
    {

        public static Guincho Criar(Porte porte) => porte switch
        {
            Porte.Pequeno => new GuinchoPequeno(porte),
            Porte.Medio => new GuinchoMedio(porte),
            Porte.Grande => new GuinchoGrande(porte),
            _ => throw new ApplicationException("Porte de Guincho desconhecido.")
        };
    }
}
