//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class DocentexCurso
    {
        public int Id_docente { get; set; }
        public int Id_curso { get; set; }
        public string Semestre { get; set; }
    
        public virtual Curso Curso { get; set; }
        public virtual Docente Docente { get; set; }
    }
}