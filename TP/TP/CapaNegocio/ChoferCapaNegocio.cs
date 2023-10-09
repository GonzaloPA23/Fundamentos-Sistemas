using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class ChoferCapaNegocio
    {
        private ChoferCapaDatos choferCapaDatos = new ChoferCapaDatos();

        public List<Chofer> ListarChoferes()
        {
            return ChoferCapaDatos.ListarChoferes();
        }

        public int RegistrarChofer(Chofer chofer, out string mensaje)
        {
            mensaje = string.Empty;
            // Validación de campos vacíos
            if (chofer.Dni == string.Empty || chofer.Nombre == string.Empty || chofer.Apellido == string.Empty || chofer.FechaNacimiento.ToString() == string.Empty || chofer.Celular == string.Empty || chofer.Correo == string.Empty)
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
            
            if(mensaje != string.Empty) return 0;
            else return choferCapaDatos.RegistrarChofer(chofer, out mensaje);
        }
    }
}
