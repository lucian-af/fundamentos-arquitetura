using System;

namespace DesignPatterns.Abstract.Factory
{
    public abstract class Veiculo
    {
        protected Veiculo(string modelo, Porte porte)
        {
            Modelo = modelo;
            Porte = porte;
        }

        public string Modelo { get; private set; }
        public Porte Porte { get; private set; }
    }

    public enum Porte
    {
        Pequeno,
        Medio,
        Grande
    }

    public class VeiculoPequeno : Veiculo
    {
        public VeiculoPequeno(string modelo, Porte porte) : base(modelo, porte) { }
    }
    public class VeiculoMedio : Veiculo
    {
        public VeiculoMedio(string modelo, Porte porte) : base(modelo, porte) { }
    }

    public class VeiculoGrande : Veiculo
    {
        public VeiculoGrande(string modelo, Porte porte) : base(modelo, porte) { }
    }

    public class VeiculoCreator
    {
        /// Pensando em Clean Code, caso o método Criar possuísse muitos parâmetros, poderíamos criar uma DTO 
        /// para simplificar o transporte de informação     
        public static Veiculo Criar(string modelo, Porte porte) => porte switch
        {
            Porte.Pequeno => new VeiculoPequeno(modelo, porte),
            Porte.Medio => new VeiculoMedio(modelo, porte),
            Porte.Grande => new VeiculoGrande(modelo, porte),
            _ => throw new ApplicationException("Porte de veiculo desconhecido.")
        };
    }
}
