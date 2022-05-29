using Decorator.Entity;

namespace Decorator.Impostos
{
    public class ICMS : Imposto
    {
        private double _aliquota = 5.00;

        public ICMS(Imposto outroImposto) : base(outroImposto) { }

        public ICMS() : base() { } 
        public override double CalcularImposto(Orcamento orcamento)
        {
            return (orcamento.Valor * _aliquota / 100) + 50 + CalculoDoOutroImposto(orcamento);
        }
    }
}
