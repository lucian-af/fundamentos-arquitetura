using System;
using System.Linq;

namespace SOLID.OCP.Solucao
{
    public abstract class DebitoConta
    {
        public string NumeroTransacao { get; private set; }
        public abstract string Debitar(decimal valor, string conta);

        public string FormatarTransacao()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15).Select(s => s[random.Next(s.Length)]).ToArray());

            return NumeroTransacao;
        }
    }
}
