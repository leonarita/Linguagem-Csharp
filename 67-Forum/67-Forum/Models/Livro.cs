using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _67_Forum.Models
{
    public class Livro
    {
        public int IdLivro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Area { get; set; }
        public decimal Preco { get; set; }

        public List<Livro> CriaDadosLivros()
        {
            var livros = new List<Livro>
            {
                new Livro { IdLivro=101, Titulo="1808", Autor="Laurentino Gomes", Area="História", Preco=32.5M },
                new Livro { IdLivro=102, Titulo="O Monge e o Executivo", Autor="James Hunter", Area="Administração", Preco=25.8M },
                new Livro { IdLivro=103, Titulo="A Cabana", Autor="William Young", Area="Romance", Preco=23.9M },
                new Livro { IdLivro=104, Titulo="O Poder do Hábito", Autor="Charles Duhigg", Area="Administração", Preco=35.2M },
                new Livro { IdLivro=105, Titulo="O Monte Cinco", Autor="Paulo Coelho", Area="Romance", Preco=29.9M }
            };

            return livros;
        }
    }
}