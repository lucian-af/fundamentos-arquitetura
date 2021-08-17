using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Composite.Interface;

namespace DesignPatterns.Composite
{
    public class Message : IMessage, IEnumerable<IMessage>
    {
        private readonly List<IMessage> _lstMessage = new();

        public string Nome { get; set; }

        public Message(string nome)
        {
            Nome = nome;
        }

        public void AdicionarFilha(IMessage filha) => _lstMessage.Add(filha);

        public void RemoverFilha(IMessage filha) => _lstMessage.Remove(filha);

        public IMessage ObterFilha(int index) => _lstMessage.ElementAt(index);

        public IMessage ObterFilha(string nome) => _lstMessage.Find(f => f.Nome.Equals(nome));

        public IEnumerable<IMessage> ObterLista() => _lstMessage;

        public void ExibirMensagem(int sub)
        {
            Console.WriteLine(new string('-', sub) + Nome);

            _lstMessage.ForEach(mensagem => mensagem.ExibirMensagem(sub + 2));
        }

        public IEnumerator<IMessage> GetEnumerator() => ((IEnumerable<IMessage>)_lstMessage).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<IMessage>)_lstMessage).GetEnumerator();
    }
}
