//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bus()
        {
            this.Pasaje = new HashSet<Pasaje>();
        }
    
        public int Id { get; set; }
        public int ChoferId { get; set; }
        public string Matricula { get; set; }
        public string Tipo { get; set; }
        public Nullable<int> AsientosDisponibles { get; set; }
        public string PuntoSalida { get; set; }
        public string Destino { get; set; }
        public System.DateTime FechaSalida { get; set; }
        public System.DateTime FechaLlegada { get; set; }
        public decimal PrecioAsiento { get; set; }
        public int CantidadAsiento { get; set; }
    
        public virtual Chofer Chofer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pasaje> Pasaje { get; set; }
    }
}
