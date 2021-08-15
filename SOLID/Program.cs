using System;
using SOLID.OCP.Solucao.Extension.Methods;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o princípio SOLID:");
            Console.WriteLine("1 - OCP");
            Console.WriteLine("2 - LSP");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    CaixaEletronico.Operacoes();
                    break;

                case '2':
                    SOLID.LSP.Solucao.CalculoArea.Calcular();
                    //SOLID.LSP.Violacao.CalculoArea.Calcular();
                    break;
            }
        }
    }
}
