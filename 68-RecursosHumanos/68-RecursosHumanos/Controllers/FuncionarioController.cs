using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _68_RecursosHumanos.Models;

namespace _68_RecursosHumanos.Controllers
{
    [OutputCache(Location =System.Web.UI.OutputCacheLocation.None, NoStore =true)]
    public class FuncionarioController : Controller
    {
        private RhContexto db = new RhContexto();

        // GET: Funcionario
        public ActionResult Index()
        {
            return View(db.Funcionario.ToList());
        }

        public ActionResult CpfNaoExiste(string CPF)
        {
            var model = db.Funcionario.Where(f => f.CPF == CPF).FirstOrDefault();

            if (model != null)
                return Json(false, JsonRequestBehavior.AllowGet);
            else
                return Json(true, JsonRequestBehavior.AllowGet);
        }

        // GET: Funcionario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario funcionario = db.Funcionario.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        // GET: Funcionario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcionario/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDFuncionario,Nome,CPF,Endereco,Cidade,Email,DataAdmissao,Dependentes,Senha,ConfirmarSenha")] Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                db.Funcionario.Add(funcionario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(funcionario);
        }

        // GET: Funcionario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario funcionario = db.Funcionario.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        // POST: Funcionario/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDFuncionario,Nome,CPF,Endereco,Cidade,Email,DataAdmissao,Dependentes,Senha,ConfirmarSenha")] Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(funcionario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(funcionario);
        }

        // GET: Funcionario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionario funcionario = db.Funcionario.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        // POST: Funcionario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Funcionario funcionario = db.Funcionario.Find(id);
            db.Funcionario.Remove(funcionario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
