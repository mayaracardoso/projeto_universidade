using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoUniversidade.Models
{
    [MetadataType(typeof(TurmaMetadado))]
    public partial class Turma{
    }

    public class TurmaMetadado
    {
        [DisplayName("Código da Turma")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        public string codigoTurma { get; set; }

        [DisplayName("Disciplina")]
        [Required(ErrorMessage = "Selecione a disciplina")]
        public int IdDisciplina { get; set; }

        [DisplayName("Professor")]
        [Required(ErrorMessage = "Selecione o professor")]
        public int IdProfessor { get; set; }

        [DisplayName("Dia da Semana")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        public string DiaSemana { get; set; }
    }
}