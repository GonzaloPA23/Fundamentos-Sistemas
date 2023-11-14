using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class ChoferCapaDatos
    {
        private static List<Chofer> choferes = new List<Chofer>();

        public static List<Chofer> ListarChoferes()
        {           
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadenaConexion))
            {
                choferes.Clear();
                try
                {
                    string query = "SELECT id,dni, nombre, apellido, fecha_nacimiento, celular, correo FROM chofer";
                    SqlCommand comando = new SqlCommand(query, oconexion);
                    comando.CommandType = CommandType.Text;
                    oconexion.Open();
                    using(SqlDataReader odr = comando.ExecuteReader())
                    {
                        while (odr.Read())
                        {
                            Chofer chofer = new Chofer();
                            chofer.Id = Convert.ToInt32(odr["id"]);
                            chofer.Dni = odr["dni"].ToString();
                            chofer.Nombre = odr["nombre"].ToString();
                            chofer.Apellido = odr["apellido"].ToString();
                            chofer.FechaNacimiento = Convert.ToDateTime(odr["fecha_nacimiento"].ToString());
                            chofer.Celular = odr["celular"].ToString();
                            chof    er.Correo = odr["correo"].ToString();
                            choferes.Add(chofer);
                        }
                    }
                }
                catch
                {
                    choferes = new List<Chofer>();
                }

            }
            return choferes;
        }


        public int RegistrarChofer(Chofer chofer, out string mensaje)
        {
            int idchofergenerado = 0;
            mensaje = string.Empty;

            try {
                using(SqlConnection oconexion = new SqlConnection(Conexion.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarChofer", oconexion);
                    cmd.Parameters.AddWithValue("dni", chofer.Dni);
                    cmd.Parameters.AddWithValue("nombre", chofer.Nombre);
                    cmd.Parameters.AddWithValue("apellido", chofer.Apellido);
                    cmd.Parameters.AddWithValue("fecha_nacimiento", chofer.FechaNacimiento);
                    cmd.Parameters.AddWithValue("celular", chofer.Celular);
                    cmd.Parameters.AddWithValue("correo", chofer.Correo);
                    cmd.Parameters.Add("idResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idchofergenerado = Convert.ToInt32(cmd.Parameters["idResultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex) 
            {
                idchofergenerado = 0;
                mensaje = ex.Message;
            }
            return idchofergenerado;
        }
    }
}
