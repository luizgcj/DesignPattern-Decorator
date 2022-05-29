using Decorator.Entity;
using Decorator.Impostos;
using System;

namespace Decorator.Helper
{
    public class CalculadorImposto
    {
        private Orcamento _orcamento;
        private Imposto _imposto;
        public CalculadorImposto (Orcamento orcamento, Imposto imposto)
        {
            _orcamento = orcamento;
            _imposto = imposto;
        }

        public void Calcular()
        {
            Console.WriteLine(_imposto.CalcularImposto(_orcamento));
        }
    }
}
