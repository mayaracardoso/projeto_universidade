﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BaancoUniversidadeEntities1 : DbContext
    {
        public BaancoUniversidadeEntities1()
            : base("name=BaancoUniversidadeEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administrador> Administrador { get; set; }
        public virtual DbSet<Aluno> Aluno { get; set; }
        public virtual DbSet<Aluno_Turma> Aluno_Turma { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<CursoTurno> CursoTurno { get; set; }
        public virtual DbSet<Disciplina> Disciplina { get; set; }
        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<Turma> Turma { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }
    }
}
