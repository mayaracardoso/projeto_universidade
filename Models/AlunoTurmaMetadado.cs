using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoUniversidade.Models
{
    [MetadataType(typeof(Aluno_TurmaMetadado))]
    public partial class Aluno_Turma{
    }

    public class Aluno_TurmaMetadado
    {
        [DisplayName("Turma")]
        [Required(ErrorMessage = "Selecione a turma")]
        public int IdTurma { get; set; }

        [DisplayName("Aluno")]
        [Required(ErrorMessage = "Selecione o aluno")]
        public int IdAluno { get; set; }

        [DisplayName("Média")]
        public decimal media { get; set; }

        [DisplayName("Faltas")]
        public int faltas { get; set; }
    }
}