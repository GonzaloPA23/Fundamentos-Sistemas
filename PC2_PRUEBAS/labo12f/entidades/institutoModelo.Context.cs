﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entidades
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbinstitutoEntities : DbContext
    {
        public dbinstitutoEntities()
            : base("name=dbinstitutoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Docente> Docente { get; set; }
        public virtual DbSet<DocentexCurso> DocentexCurso { get; set; }
    }
}
