using System;
using System.Linq;

namespace DesignPatterns.Behavioral.Strategy
{
    public class PagamentoBoletoFacade : IPagamentoBoletoFacade
    {
        public string GerarBoleto()
            => new(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
    }
}
