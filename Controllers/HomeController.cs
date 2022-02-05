using ProjetoUniversidade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoUniversidade.Controllers
{
    public class HomeController : Controller
    {
        private BaancoUniversidadeEntities1 db = new BaancoUniversidadeEntities1();
        public ActionResult Index()
        {
            ViewBag.Turno = new SelectList(db.Turno, "IdTurno", "descricaoTurno");
            return View();
        }

        public ActionResult PesquisarCurso(PesquisaCurso pesquisa)
        {
            var cursos = from c in db.Curso join ct in db.CursoTurno on c.IdCurso equals ct.IdCurso
                         where ct.IdTurno == pesquisa.IdTurno
                         select new ResultadoPesquisaCurso
                         {
                             nomeCurso = c.nomeCurso,
                             modalidade = c.modalidade,
                             duracao = c.duracao
                         };
            return Json(cursos, JsonRequestBehavior.AllowGet);
        }
        public ActionResult PesquisarDisciplina(PesquisaDisciplina pesquisa)
        {
            var disciplinas = from d in db.Disciplina
                              where d.IdCurso == pesquisa.IdCurso && d.periodo == pesquisa.periodo
                              select new ResultadoPesquisaDisciplina
                              {
                                  codigoDisciplina = d.codigoDisciplina,
                                  nomeDisciplina = d.nomeDisciplina,
                                  numeroAulas = d.numeroAulas
                              };
            return Json(disciplinas, JsonRequestBehavior.AllowGet);
        }

        public ActionResult PesquisarAgenda(PesquisaAgenda pesquisa)
        {
            var agenda = from t in db.Turma
                         join p in db.Professor on t.IdProfessor equals p.IdProfessor
                         join d in db.Disciplina on t.IdDisciplina equals d.IdDisciplina
                         join a in db.Aluno_Turma on t.IdTurma equals a.IdTurma
                         where t.IdProfessor == pesquisa.IdProfessor && t.IdDisciplina == pesquisa.IdDisciplina
                         select new ResultadoPesquisaAgenda
                         {
                             codigoTurma = t.codigoTurma,
                             nomeDisciplina = d.nomeDisciplina,
                             periodo = d.periodo,
                             numAlunos = db.Aluno_Turma.Where(a => a.IdTurma == t.IdTurma).Count(),
                             nomeProfessor = p.nomeProfessor
                         };
            return Json(agenda, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}