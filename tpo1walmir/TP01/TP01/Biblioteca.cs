using System;
using System.Collections.Generic;
using System.Text;
using TP01.Detalhes;

namespace TP01
{
    class Biblioteca
    {
        public static Book GetConteudo()
        {
            Author author1 = new Author();
            author1.Name = "walmir";
            author1.Email = "walmir@gmail.com";
            author1.Gender = 'm';

            Author author2 = new Author();
            author2.Name = "Sthepan King";
            author2.Email = "sthepanking@gmail.com";
            author2.Gender = 'M';

				Author author3 = new Author();
				author3.Name = "Machado de Assis";
				author3.Email = "machadodeassis@gmail.com";
				author3.Gender = 'M';

				Author author4 = new Author();
				author4.Name = "Cora Coralina";
				author4.Email = "coracoralina@gmail.com";
				author4.Gender = 'F';

				Author author5 = new Author();
				author5.Name = "Manuel Bandeira";
				author5.Email = "manuelbandeira@live.com";
				author5.Gender = 'M';

				Author author6 = new Author();
				author6.Name = "Cecilia Meireles";
				author6.Email = "ceciliameireles@yahoo.com";
				author6.Gender = 'F';

				Author author7 = new Author();
				author7.Name = "Gilberto Freyre";
				author7.Email = "gilbertofreyre@hotmail.com";
				author7.Gender = 'M';

			List<Author> authors = new List<Author>();
            authors.Add(author1);
            authors.Add(author2);
				authors.Add(author3);
				authors.Add(author4);
				authors.Add(author5);
				authors.Add(author6);
				authors.Add(author7);
				


				Book book = new Book("IFSP Web II", authors, 155.5,2);

				
			return book;
        }
    }
}
