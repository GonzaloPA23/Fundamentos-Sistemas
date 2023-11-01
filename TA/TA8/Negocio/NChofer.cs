using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class NChofer
    {
        private DChofer dChofer = new DChofer();

        public List<EChofer> ListarChoferes()
        {
            return DChofer.ListarChoferes();
        }

        public int RegistrarChofer(EChofer chofer, out string mensaje)
        {
            mensaje = string.Empty;
            // Validación de campos vacíos
            if (chofer.Dni == string.Empty || chofer.NombreCompleto == string.Empty || chofer.Celular == string.Empty || chofer.Correo == string.Empty)
            {
                mensaje += "Debe llenar todos los campos";
                return 0;
            }
            // Validación de que el DNI sea un número
            if (!int.TryParse(chofer.Dni, out int dni))
            {
                mensaje += "El DNI debe ser un número";
                return 0;
            }          
            // Validación de que el DNI tenga 8 dígitos
            if (chofer.Dni.Length != 8)
            {
                mensaje += "El DNI debe tener 8 dígitos";
                return 0;
            }
            // Validación de que el correo tenga el formato correcto
            if (!chofer.Correo.Contains("@") || !chofer.Correo.Contains("."))
            {
                mensaje += "El correo debe tener el formato correcto";
                return 0;
            }
            // Validación de que el celular tenga 9 dígitos y sea un número
            if (!int.TryParse(chofer.Celular, out int celular) || chofer.Celular.Length != 9)
            {
                mensaje += "El celular debe tener 9 dígitos";
                return 0;
            }

            if (mensaje != string.Empty) return 0;
            else return dChofer.RegistrarChofer(chofer, out mensaje);
        }

        public int EliminarChofer(int idchofer)
        {        
            if (idchofer == 0)
            {
                return 0;
            }
            else return dChofer.EliminarChofer(idchofer);
        }

        public String Modificar(EChofer chofer)
        {
            string mensaje = string.Empty;
            // Validación de campos vacíos
            if (chofer.Dni == string.Empty || chofer.NombreCompleto == string.Empty || chofer.Celular == string.Empty || chofer.Correo == string.Empty)
            {
                mensaje += "Debe llenar todos los campos";
                return mensaje;
            }
            // Validación de que el DNI sea un número
            if (!int.TryParse(chofer.Dni, out int dni))
            {
                mensaje += "El DNI debe ser un número";
                return mensaje;
            }
            // Validación de que el DNI tenga 8 dígitos
            if (chofer.Dni.Length != 8)
            {
                mensaje += "El DNI debe tener 8 dígitos";
                return mensaje;
            }
            // Validación de que el correo tenga el formato correcto
            if (!chofer.Correo.Contains("@") || !chofer.Correo.Contains("."))
            {
                mensaje += "El correo debe tener el formato correcto";
                return mensaje;
            }
            // Validación de que el celular tenga 9 dígitos y sea un número
            if (!int.TryParse(chofer.Celular, out int celular) || chofer.Celular.Length != 9)
            {
                mensaje += "El celular debe tener 9 dígitos";
                return mensaje;
            }

            if (mensaje != string.Empty) return mensaje;
            else return dChofer.Modificar(chofer);          
        }
    }
}
