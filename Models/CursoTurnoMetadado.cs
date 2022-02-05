using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoUniversidade.Models
{
    [MetadataType(typeof(CursoTurnoMetadado))]
    public partial class CursoTurno
    {
    }

    public class CursoTurnoMetadado
    {
        [DisplayName("Curso")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        public int IdCurso { get; set; }
      

        [DisplayName("Turno")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        public int IdTurno { get; set; }

    }
}