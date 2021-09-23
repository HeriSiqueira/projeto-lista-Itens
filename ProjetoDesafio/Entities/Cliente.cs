using System;
using ProjetoDesafio.Entities;


namespace ProjetoDesafio.Entities
{
    class Cliente
    {
        public string  Name { get; set; }
        public string Email { get; set; }
        public DateTime DataAniversario { get; set; }

        public Cliente()
        {
        }

        public Cliente(string name, string email, DateTime dataAniversario)
        {
            Name = name;
            Email = email;
            DataAniversario = dataAniversario;
        }

        public override string ToString()
        {
            return Name
                + ", ("
                + DataAniversario.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
