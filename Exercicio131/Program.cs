using System;
using System.Collections.Generic;
using Exercicio131.Entities;
using System.Globalization;

namespace Exercicio131
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();

            Console.Write("Qual a quantidade de funcionários? ");
            int numFun = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numFun; i++)
            {
                Console.WriteLine($"Dados do Funcionário #{i}:  ");
                Console.Write("Funcionario Tercerizado (y/n)?  ");
                char resposta = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Quantidade de Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por Hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (resposta == 'y')
                {
                    Console.Write("Despesa Adiciona: ");
                    double despesa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new FunTercerizado(nome, horas, valorHora, despesa));
                } 
                else
                {
                    list.Add(new Funcionario(nome, horas, valorHora));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAGAMENTOS: ");
            foreach (Funcionario funcio in list)
            {
                Console.WriteLine(funcio.Name + " - $ " + funcio.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
