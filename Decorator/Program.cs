using Decorator.Entity;
using Decorator.Helper;
using Decorator.Impostos;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ISS iss = new ISS(new ICMS(new ICCC()));

            Orcamento orcamento = new Orcamento(3000);
            CalculadorImposto calculador = new CalculadorImposto(orcamento, iss);
            calculador.Calcular();
        }
    }
}
