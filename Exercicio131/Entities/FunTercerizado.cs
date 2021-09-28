using System;
using System.Collections.Generic;


namespace Exercicio131.Entities
{
    class FunTercerizado : Funcionario
    {
        public double DesAdicional { get; set; }

        public FunTercerizado()
        {
        }
        public FunTercerizado( string name, int horas, double valorPorHora, double desAdicional)
            : base(name, horas, valorPorHora)
        {
            DesAdicional = desAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DesAdicional;
        }
    }

}
