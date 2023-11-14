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
    
    public partial class Empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleados()
        {
            this.HistorialEmpleos = new HashSet<HistorialEmpleos>();
        }
    
        public int CódigoEmpleado { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public System.DateTime FechaDeNacimiento { get; set; }
        public System.DateTime FechaDeContratación { get; set; }
        public decimal Salario { get; set; }
        public Nullable<int> CódigoEmpleo { get; set; }
    
        public virtual Empleos Empleos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialEmpleos> HistorialEmpleos { get; set; }
    }
}
