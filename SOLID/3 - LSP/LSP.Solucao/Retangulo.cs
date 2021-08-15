using System;

namespace SOLID.LSP.Solucao
{
    public class Retangulo : Paralelogramo
    {
        public Retangulo(int altura, int largura)
            : base(altura, largura)
        {
            if (altura.Equals(largura))
                throw new ArgumentException("Os lados do retângulo devem ser diferentes.");
        }
    }
}
