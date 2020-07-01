using _67_Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _67_Forum.Controllers
{
    public class LivroController : Controller
    {
        private List<Livro> livros;

        public LivroController()
        {
            livros = new Livro().CriaDadosLivros().OrderBy(x => x.Titulo).ToList();
        }

        // GET: Livro
        public ActionResult Index()
        {
            return View(livros);
        }

        public ActionResult Detalhes(int idLivro)
        {
            return View(livros.Find(x => x.IdLivro == idLivro));
        }

        public ActionResult Area(string area)
        {
            ViewBag.Cabecalho = area;
            return View(livros.Where(x => x.Area == area));
        }

    }
}