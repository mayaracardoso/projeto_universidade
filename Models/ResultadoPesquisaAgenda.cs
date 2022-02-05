using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoUniversidade.Models
{
    public class ResultadoPesquisaAgenda
    {
        public string codigoTurma { get; set; }
        public string nomeDisciplina { get; set; }
        public int periodo { get; set; }
        public long numAlunos { get; set; }
        public string nomeProfessor { get; set; }
    }
}