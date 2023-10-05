﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class UsuarioCapaNegocio
    {
        private UsuarioCapaDatos usuarioCapaDatos = new UsuarioCapaDatos();
       
        public List<Usuario> ListarUsuarios()
        {
            return usuarioCapaDatos.ListarUsuarios();
        }
    }
}