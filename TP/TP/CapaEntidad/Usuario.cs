﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int Id { get; set; }
        public Rol ObjRol { get; set; }
        public String Dni { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Clave { get; set; }
        public String Correo { get; set; }
    }
}
