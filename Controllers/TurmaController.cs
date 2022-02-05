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
    public class TurmaController : Controller
    {
        private BaancoUniversidadeEntities1 db = new BaancoUniversidadeEntities1();

        // GET: Turma
        public ActionResult Index()
        {
            var turma = db.Turma.Include(t => t.Disciplina).Include(t => t.Professor);
            return View(turma.ToList());
        }

        // GET: Turma/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turma turma = db.Turma.Find(id);
            if (turma == null)
            {
                return HttpNotFound();
            }
            return View(turma);
        }

        // GET: Turma/Create
        public ActionResult Create()
        {
            ViewBag.IdDisciplina = new SelectList(db.Disciplina, "IdDisciplina", "nomeDisciplina");
            ViewBag.IdProfessor = new SelectList(db.Professor, "IdProfessor", "nomeProfessor");
            return View();
        }

        // POST: Turma/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTurma,codigoTurma,IdDisciplina,IdProfessor,DiaSemana")] Turma turma)
        {
            if (ModelState.IsValid)
            {
                db.Turma.Add(turma);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdDisciplina = new SelectList(db.Disciplina, "IdDisciplina", "nomeDisciplina", turma.IdDisciplina);
            ViewBag.IdProfessor = new SelectList(db.Professor, "IdProfessor", "nomeProfessor", turma.IdProfessor);
            return View(turma);
        }

        // GET: Turma/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turma turma = db.Turma.Find(id);
            if (turma == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdDisciplina = new SelectList(db.Disciplina, "IdDisciplina", "nomeDisciplina", turma.IdDisciplina);
            ViewBag.IdProfessor = new SelectList(db.Professor, "IdProfessor", "nomeProfessor", turma.IdProfessor);
            return View(turma);
        }

        // POST: Turma/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTurma,codigoTurma,IdDisciplina,IdProfessor,DiaSemana")] Turma turma)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turma).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdDisciplina = new SelectList(db.Disciplina, "IdDisciplina", "nomeDisciplina", turma.IdDisciplina);
            ViewBag.IdProfessor = new SelectList(db.Professor, "IdProfessor", "nomeProfessor", turma.IdProfessor);
            return View(turma);
        }

        // GET: Turma/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turma turma = db.Turma.Find(id);
            if (turma == null)
            {
                return HttpNotFound();
            }
            return View(turma);
        }

        // POST: Turma/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Turma turma = db.Turma.Find(id);
            db.Turma.Remove(turma);
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
