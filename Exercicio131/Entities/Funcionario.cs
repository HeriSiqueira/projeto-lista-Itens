using System;
using System.Collections.Generic;


namespace Exercicio131.Entities
{
    class Funcionario
    {
        public string Name { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string name, int horas, double valorPorHora)
        {
            Name = name;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento()
        {
            return Horas * ValorPorHora;
        }
    }
}
