using Decorator.Entity;

namespace Decorator.Impostos
{
    public abstract class Imposto
    {
        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public Imposto()
        {
            this.OutroImposto = null;
        }
        public abstract double CalcularImposto(Orcamento orcamento);

        public Imposto OutroImposto { get; set; }
        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (this.OutroImposto == null) return 0;
            return OutroImposto.CalcularImposto(orcamento);

        }

    }
}
