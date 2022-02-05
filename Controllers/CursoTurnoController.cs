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
    public class CursoTurnoController : Controller
    {
        private BaancoUniversidadeEntities1 db = new BaancoUniversidadeEntities1();

        // GET: CursoTurno
        public ActionResult Index()
        {
            var cursoTurno = db.CursoTurno.Include(c => c.Curso).Include(c => c.Turno);
            return View(cursoTurno.ToList());
        }

        // GET: CursoTurno/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CursoTurno cursoTurno = db.CursoTurno.Find(id);
            if (cursoTurno == null)
            {
                return HttpNotFound();
            }
            return View(cursoTurno);
        }

        // GET: CursoTurno/Create
        public ActionResult Create()
        {
            ViewBag.IdCurso = new SelectList(db.Curso, "IdCurso", "nomeCurso");
            ViewBag.IdTurno = new SelectList(db.Turno, "IdTurno", "descricaoTurno");
            return View();
        }

        // POST: CursoTurno/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCursoTurno,IdCurso,IdTurno")] CursoTurno cursoTurno)
        {
            if (ModelState.IsValid)
            {
                db.CursoTurno.Add(cursoTurno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCurso = new SelectList(db.Curso, "IdCurso", "nomeCurso", cursoTurno.IdCurso);
            ViewBag.IdTurno = new SelectList(db.Turno, "IdTurno", "descricaoTurno", cursoTurno.IdTurno);
            return View(cursoTurno);
        }

        // GET: CursoTurno/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CursoTurno cursoTurno = db.CursoTurno.Find(id);
            if (cursoTurno == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCurso = new SelectList(db.Curso, "IdCurso", "nomeCurso", cursoTurno.IdCurso);
            ViewBag.IdTurno = new SelectList(db.Turno, "IdTurno", "descricaoTurno", cursoTurno.IdTurno);
            return View(cursoTurno);
        }

        // POST: CursoTurno/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCursoTurno,IdCurso,IdTurno")] CursoTurno cursoTurno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cursoTurno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCurso = new SelectList(db.Curso, "IdCurso", "nomeCurso", cursoTurno.IdCurso);
            ViewBag.IdTurno = new SelectList(db.Turno, "IdTurno", "descricaoTurno", cursoTurno.IdTurno);
            return View(cursoTurno);
        }

        // GET: CursoTurno/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CursoTurno cursoTurno = db.CursoTurno.Find(id);
            if (cursoTurno == null)
            {
                return HttpNotFound();
            }
            return View(cursoTurno);
        }

        // POST: CursoTurno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CursoTurno cursoTurno = db.CursoTurno.Find(id);
            db.CursoTurno.Remove(cursoTurno);
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
