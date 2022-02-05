using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoUniversidade.Models
{
    [MetadataType(typeof(TurnoMetadado))]
    public partial class Turno{
    }

    public class TurnoMetadado
    {
        [DisplayName("Descrição do turno")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        public string descricaoTurno { get; set; }
    }
}