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
    
    public partial class Professor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Professor()
        {
            this.Turma = new HashSet<Turma>();
        }
    
        public int IdProfessor { get; set; }
        public string nomeProfessor { get; set; }
        public string matriculaProfessor { get; set; }
        public string cpfProfessor { get; set; }
        public string formacao { get; set; }
        public string telefoneProfessor { get; set; }
        public string emailProfessor { get; set; }
        public string senhaProfessor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turma> Turma { get; set; }
    }
}