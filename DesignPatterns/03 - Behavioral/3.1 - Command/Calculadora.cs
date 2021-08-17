using System;

namespace DesignPatterns.Command
{
    internal class Calculadora
    {
        private int _valorAtual;


        public void Operacao(char operador, int valor)
        {
            _valorAtual = operador switch
            {
                '+' => _valorAtual + valor,
                '-' => _valorAtual - valor,
                '*' => _valorAtual * valor,
                '/' => valor > 0 ? _valorAtual / valor : _valorAtual,
                _ => _valorAtual
            };

            Console.WriteLine("(dado {1} {2}) - Valor atual = {0,3}", _valorAtual, operador, valor);
        }
    }
}
