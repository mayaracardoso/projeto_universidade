using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoUniversidade.Models
{
    [MetadataType(typeof(AlunoMetadado))]
    public partial class Aluno{
    }

    public class AlunoMetadado{

        [DisplayName("Nome do Aluno")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        [StringLength(40, ErrorMessage = "O nome deve ter até 40 caracteres")]
        public string nomeAluno { get; set; }

        [DisplayName("Matrícula")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        [StringLength(7, MinimumLength = 7, ErrorMessage = "A matrícula deve ter 7 caracteres")]
        public string matriculaAluno { get; set; }

        [DisplayName("CPF")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "Digite apenas os números do CPF")]
        public string cpfAluno { get; set; }

        [DisplayName("Telefone")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        [StringLength(13, MinimumLength = 12, ErrorMessage = "Digite apenas os números do telefone")]
        public string telefoneAluno { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        [StringLength(40, ErrorMessage = "O e-mail deve ter até 40 caracteres")]
        public string emailAluno { get; set; }

        [DisplayName("Senha")]
        [Required(ErrorMessage = "Obrigatório preencher este campo")]
        [StringLength(8, MinimumLength = 6, ErrorMessage = "A senha deve ter de 6 a 8 caracteres")]
        public string senhaAluno { get; set; }
    }
}