//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoUniversidade.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aluno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aluno()
        {
            this.Aluno_Turma = new HashSet<Aluno_Turma>();
        }
    
        public int IdAluno { get; set; }
        public string nomeAluno { get; set; }
        public string matriculaAluno { get; set; }
        public string cpfAluno { get; set; }
        public string telefoneAluno { get; set; }
        public string emailAluno { get; set; }
        public string senhaAluno { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aluno_Turma> Aluno_Turma { get; set; }
    }
}
