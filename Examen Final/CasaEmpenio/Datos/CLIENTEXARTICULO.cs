//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class CLIENTEXARTICULO
    {
        public string dni { get; set; }
        public string codarticulo { get; set; }
        public Nullable<System.DateTime> fventa { get; set; }
    
        public virtual ARTICULO ARTICULO { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
    }
}
