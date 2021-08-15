using System;
using DesignPatterns.Abstract.Factory;
using DesignPatterns.Adapter;
using DesignPatterns.Command;
using DesignPatterns.Facade;
using DesignPatterns.Factory.Method;
using DesignPatterns.Observable;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Padrões Criacionais");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Factory Method");
            Console.WriteLine("3 - Singleton");
            Console.WriteLine("------------------------");
            Console.WriteLine("Padrões Estruturais");
            Console.WriteLine("------------------------");
            Console.WriteLine("4 - Adapter");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("------------------------");
            Console.WriteLine("Padrões Comportamentais");
            Console.WriteLine("------------------------");
            Console.WriteLine("6 - Command");
            Console.WriteLine("7 - Strategy");
            Console.WriteLine("8 - Observer");
            Console.WriteLine("------------------------");

            var opcao = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            Executar(opcao);

            Console.ReadKey();
            Console.Clear();
            Main();
        }

        public static void Executar(ConsoleKeyInfo opcao)
        {
            switch (opcao.KeyChar)
            {
                case '1': ExecutarAbstractFactory.Executar(); break;
                case '2': ExecutarFactoryMethod.Executar(); break;
                case '3': ExecutarSingleton.Executar(); break;
                case '4': ExecutarAdapter.Executar(); break;
                case '5': ExecutarFacade.Executar(); break;
                case '6': ExecutarCommand.Executar(); break;
                case '7': ExecutarStrategy.Executar(); break;
                case '8': ExecutarObservable.Executar(); break;
            };
        }
    }
}
