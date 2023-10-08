using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        public int Registrar(Usuario usuario, out string mensaje)
        {
            mensaje = string.Empty;
            // Validación de campos vacíos
            if (usuario.Dni == string.Empty || usuario.Nombre == string.Empty || usuario.Apellido == string.Empty || usuario.Clave == string.Empty || usuario.Correo == string.Empty)
            {
                mensaje += "Debe llenar todos los campos";
                return 0;
            }
            // Validación de que el DNI sea un número
            if (!int.TryParse(usuario.Dni, out int dni))
            {
                mensaje += "El DNI debe ser un número";
                return 0;
            }
            // Validación de que el DNI tenga 8 dígitos
            if (usuario.Dni.Length != 8)
            {
                mensaje += "El DNI debe tener 8 dígitos";
                return 0;
            }            
            // Validación de que el correo tenga el formato correcto
            if (!usuario.Correo.Contains("@") || !usuario.Correo.Contains("."))
            {
                mensaje += "El correo debe tener el formato correcto";
                return 0;
            }

            if (mensaje != string.Empty) return 0;
            else return usuarioCapaDatos.RegistrarUsuario(usuario, out mensaje);
        }
    }
}
