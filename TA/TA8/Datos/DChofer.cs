using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    public class DChofer
    {
        private static List<EChofer> choferes = new List<EChofer>();
        public static List<EChofer> ListarChoferes()
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadenaConexion))
            {
                choferes.Clear();
                try
                {
                    string query = "SELECT * FROM Chofer";
                    SqlCommand comando = new SqlCommand(query, oconexion);
                    comando.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader odr = comando.ExecuteReader())
                    {
                        while (odr.Read())
                        {
                            EChofer chofer = new EChofer();
                            chofer.Id = Convert.ToInt32(odr["Id"]);
                            chofer.Dni = odr["Dni"].ToString();
                            chofer.NombreCompleto = odr["NombreCompleto"].ToString();                       
                            chofer.Celular = odr["Celular"].ToString();
                            chofer.Correo = odr["Correo"].ToString();
                            chofer.FechaRegistro = odr["FechaRegistro"].ToString();
                            choferes.Add(chofer);
                        }
                        odr.Close();
                    }
                }
                catch
                {
                    choferes = new List<EChofer>();
                }
                finally
                {
                    oconexion.Close();
                }
            }
            return choferes;
        }

        public int RegistrarChofer(EChofer chofer, out string mensaje)
        {
            int idchofergenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarChofer", oconexion);
                    cmd.Parameters.AddWithValue("Dni", chofer.Dni);
                    cmd.Parameters.AddWithValue("NombreCompleto", chofer.NombreCompleto);
                    cmd.Parameters.AddWithValue("Celular", chofer.Celular);
                    cmd.Parameters.AddWithValue("Correo", chofer.Correo);
                    cmd.Parameters.Add("idResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idchofergenerado = Convert.ToInt32(cmd.Parameters["idResultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                    oconexion.Close();
                }
            }
            catch (Exception ex)
            {
                idchofergenerado = 0;
                mensaje = ex.Message;
            }
            return idchofergenerado;
        }

        public int EliminarChofer(int idchofer)
        {         
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarChofer", oconexion);
                    cmd.Parameters.AddWithValue("Id", idchofer);                
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();                  
                    oconexion.Close();
                }
            }
            catch (Exception ex)
            {
                idchofer = 0;
            }

            return idchofer;
        }

        public string Modificar(EChofer chofer)
        {
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadenaConexion))
                {
                    String update = String.Format("UPDATE Chofer SET Dni='{0}', NombreCompleto='{1}', Celular='{2}', Correo='{3}' " +
                        "WHERE Id={4}", chofer.Dni, chofer.NombreCompleto, chofer.Celular, chofer.Correo, chofer.Id);
                    SqlCommand cmd = new SqlCommand(update, oconexion);
                    oconexion.Open(); 
                    cmd.ExecuteNonQuery();
                }
                return "Chofer modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
