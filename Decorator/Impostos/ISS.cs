using Decorator.Entity;
using System;

namespace Decorator.Impostos
{
    public class ISS : Imposto
    {
        private double _aliquota = 6.00;

        public ISS (Imposto outroImposto) : base(outroImposto) { }

        public ISS() : base() { }

        public override double CalcularImposto(Orcamento orcamento)
        {
            return (orcamento.Valor * _aliquota / 100) + 50 + CalculoDoOutroImposto(orcamento);
        }

        
    }
}
