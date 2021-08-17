using System;
using DesignPatterns.Composite.Interface;

namespace DesignPatterns.Composite
{
    public class DomainMessage : IMessage
    {
        public string Nome { get; set; }

        public DomainMessage(string nome) => Nome = nome;

        public void ExibirMensagem(int sub)
            => Console.WriteLine($"{new string('-', sub)}{Nome}");
    }
}
