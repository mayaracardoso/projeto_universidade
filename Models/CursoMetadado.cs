using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoUniversidade.Models
{
    [MetadataType(typeof(CursoMetadado))]
    public partial class Curso{
    }

    public class CursoMetadado
    {
        [DisplayName("Nome do Curso")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        public string nomeCurso { get; set; }

        [DisplayName("Duração em semestres")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        public int duracao { get; set; }

        [DisplayName("Modalidade")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        public string modalidade { get; set; }
    }
}