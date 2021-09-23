using System;
using System.Collections.Generic;
using System.Globalization;


namespace ProjetoDesafio.Entities
{
    class OrderItem
    {
        public double Preco { get; set; }
        public int  Quantidade { get; set; }
        public Produto Produto { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(double preco, int quantidade, Produto produto)
        {
            Preco = preco;
            Quantidade = quantidade;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
            return Produto.Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantidade
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
