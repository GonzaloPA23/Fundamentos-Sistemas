using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class NUsuario
    {
        private DUsuario dUsuario = new DUsuario();
        public List<Usuario> ListarUsuarios()
        {
            return dUsuario.ListarUsuarios();
        }
        public int RegistrarUsuario(Usuario usuario, out string mensaje)
        {
            mensaje = string.Empty;
            // Validacion de campos vacios
            if (usuario.Dni == string.Empty || usuario.Nombre == string.Empty || usuario.Apellido == string.Empty || usuario.Clave == string.Empty || usuario.Correo == string.Empty)
            {
                mensaje = "Debe completar todos los campos";
                return 0;
            }
            // Validacion de que el DNI sea un número y tenga 8 dígitos
            if (!int.TryParse(usuario.Dni, out int dni) || usuario.Dni.Length != 8)
            {
                mensaje = "El DNI debe ser un número de 8 dígitos";
                return 0;
            }
            // Validacion de que el correo sea un correo válido
            if (!usuario.Correo.Contains("@") || !usuario.Correo.Contains("."))
            {
                mensaje = "El correo debe ser un correo válido";
                return 0;
            }
            // Validación que la clave tenga al menos 8 caracteres, una mayuscula, un caracter especial y un numero
            if (usuario.Clave.Length < 8 || !usuario.Clave.Any(char.IsUpper))
            {
                mensaje = "La clave debe tener al menos 8 caracteres, una mayuscula, un caracter especial y un numero";
                return 0;
            }

            if (mensaje != string.Empty) return 0;
            else return dUsuario.RegistrarUsuario(usuario, out mensaje);

        }   
    }
}
