using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoUniversidade.Models
{
    [MetadataType(typeof(DisciplinaMetadado))]
    public partial class Disciplina {
    }

    public class DisciplinaMetadado
    {
        [DisplayName("Nome da Disciplina")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        public string nomeDisciplina { get; set; }

        [DisplayName("Código da Disciplina")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        public string codigoDisciplina { get; set; }

        [DisplayName("Total de Aulas")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        public int numeroAulas { get; set; }

        [DisplayName("Semestre (nº)")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        public string periodo { get; set; }

        [DisplayName("Curso")]
        [Required(ErrorMessage = "Selecione o curso")]
        public int IdCurso { get; set; } 

    }
}