using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoUniversidade.Models;

namespace ProjetoUniversidade.Controllers
{
    public class Aluno_TurmaController : Controller
    {
        private BaancoUniversidadeEntities1 db = new BaancoUniversidadeEntities1();

        // GET: Aluno_Turma
        public ActionResult Index()
        {
            var aluno_Turma = db.Aluno_Turma.Include(a => a.Aluno).Include(a => a.Turma);
            return View(aluno_Turma.ToList());
        }

        // GET: Aluno_Turma/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluno_Turma aluno_Turma = db.Aluno_Turma.Find(id);
            if (aluno_Turma == null)
            {
                return HttpNotFound();
            }
            return View(aluno_Turma);
        }

        // GET: Aluno_Turma/Create
        public ActionResult Create()
        {
            ViewBag.IdAluno = new SelectList(db.Aluno, "IdAluno", "nomeAluno");
            ViewBag.IdTurma = new SelectList(db.Turma, "IdTurma", "codigoTurma");
            return View();
        }

        // POST: Aluno_Turma/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAluno_Turma,IdTurma,IdAluno,media,faltas")] Aluno_Turma aluno_Turma)
        {
            if (ModelState.IsValid)
            {
                db.Aluno_Turma.Add(aluno_Turma);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdAluno = new SelectList(db.Aluno, "IdAluno", "nomeAluno", aluno_Turma.IdAluno);
            ViewBag.IdTurma = new SelectList(db.Turma, "IdTurma", "codigoTurma", aluno_Turma.IdTurma);
            return View(aluno_Turma);
        }

        // GET: Aluno_Turma/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluno_Turma aluno_Turma = db.Aluno_Turma.Find(id);
            if (aluno_Turma == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdAluno = new SelectList(db.Aluno, "IdAluno", "nomeAluno", aluno_Turma.IdAluno);
            ViewBag.IdTurma = new SelectList(db.Turma, "IdTurma", "codigoTurma", aluno_Turma.IdTurma);
            return View(aluno_Turma);
        }

        // POST: Aluno_Turma/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdAluno_Turma,IdTurma,IdAluno,media,faltas")] Aluno_Turma aluno_Turma)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aluno_Turma).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdAluno = new SelectList(db.Aluno, "IdAluno", "nomeAluno", aluno_Turma.IdAluno);
            ViewBag.IdTurma = new SelectList(db.Turma, "IdTurma", "codigoTurma", aluno_Turma.IdTurma);
            return View(aluno_Turma);
        }

        // GET: Aluno_Turma/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aluno_Turma aluno_Turma = db.Aluno_Turma.Find(id);
            if (aluno_Turma == null)
            {
                return HttpNotFound();
            }
            return View(aluno_Turma);
        }

        // POST: Aluno_Turma/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aluno_Turma aluno_Turma = db.Aluno_Turma.Find(id);
            db.Aluno_Turma.Remove(aluno_Turma);
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
