﻿using System;
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
    public class DisciplinaController : Controller
    {
        private BaancoUniversidadeEntities1 db = new BaancoUniversidadeEntities1();

        // GET: Disciplina
        public ActionResult Index()
        {
            var disciplina = db.Disciplina.Include(d => d.Curso);
            return View(disciplina.ToList());
        }

        // GET: Disciplina/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disciplina disciplina = db.Disciplina.Find(id);
            if (disciplina == null)
            {
                return HttpNotFound();
            }
            return View(disciplina);
        }

        // GET: Disciplina/Create
        public ActionResult Create()
        {
            ViewBag.IdCurso = new SelectList(db.Curso, "IdCurso", "nomeCurso");
            return View();
        }

        // POST: Disciplina/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdDisciplina,nomeDisciplina,codigoDisciplina,numeroAulas,periodo,IdCurso")] Disciplina disciplina)
        {
            if (ModelState.IsValid)
            {
                db.Disciplina.Add(disciplina);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCurso = new SelectList(db.Curso, "IdCurso", "nomeCurso", disciplina.IdCurso);
            return View(disciplina);
        }

        // GET: Disciplina/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disciplina disciplina = db.Disciplina.Find(id);
            if (disciplina == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCurso = new SelectList(db.Curso, "IdCurso", "nomeCurso", disciplina.IdCurso);
            return View(disciplina);
        }

        // POST: Disciplina/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdDisciplina,nomeDisciplina,codigoDisciplina,numeroAulas,periodo,IdCurso")] Disciplina disciplina)
        {
            if (ModelState.IsValid)
            {
                db.Entry(disciplina).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCurso = new SelectList(db.Curso, "IdCurso", "nomeCurso", disciplina.IdCurso);
            return View(disciplina);
        }

        // GET: Disciplina/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disciplina disciplina = db.Disciplina.Find(id);
            if (disciplina == null)
            {
                return HttpNotFound();
            }
            return View(disciplina);
        }

        // POST: Disciplina/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Disciplina disciplina = db.Disciplina.Find(id);
            db.Disciplina.Remove(disciplina);
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
