using System;
using System.Collections.Generic;
using System.Text;

namespace TP01.Detalhes
{
    class Book
    {
        public string Nome { set; get; }
        public List<Author> Authors { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

        public Book(string nome, List<Author> authors, double price)
        {
            Nome = nome;
            Authors = authors;
            Price = price;
        }
        public Book(string nome, List<Author> authors, double price, int qty)
        {
            Nome = nome;
            Authors = authors;
            Price = price;
            Qty = qty;
        }

        public string GetAuthorsNames()
        {
            var linhas = new StringBuilder();
            foreach (var author in Authors)
            {
                linhas.AppendLine(author.Name);
            }
            return linhas.ToString();
        }

        public override string ToString()
        {
            var linhas = new StringBuilder();
            linhas.AppendLine("Livro: " + Nome + " Price: " + Price + " Qty: " + Qty);
            linhas.AppendLine("====================================================");
            linhas.AppendLine("Autores: ");
            foreach (var author in Authors)
            {
                linhas.AppendLine(author.ToString());
            }
            return linhas.ToString();
        }
    }
}
