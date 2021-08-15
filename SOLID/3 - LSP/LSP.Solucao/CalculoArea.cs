using System;

namespace SOLID.LSP.Solucao
{
    public class CalculoArea
    {
        private static void ObterAreaParalelogramo(Paralelogramo forma)
        {
            Console.Clear();
            Console.WriteLine("Cálculo da área do Retângulo");
            Console.WriteLine();
            Console.WriteLine($"{forma.Altura} * {forma.Largura}");
            Console.WriteLine();
            Console.WriteLine(forma.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quad = new Quadrado(5, 5);
            var ret = new Retangulo(10, 5);

            ObterAreaParalelogramo(quad);
            ObterAreaParalelogramo(ret);
        }
    }
}
