//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleos()
        {
            this.Empleados = new HashSet<Empleados>();
            this.HistorialEmpleos = new HashSet<HistorialEmpleos>();
        }
    
        public int Código { get; set; }
        public string NombreDelEmpleo { get; set; }
        public decimal SalarioMínimo { get; set; }
        public decimal SalarioMáximo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleados> Empleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialEmpleos> HistorialEmpleos { get; set; }
    }
}
