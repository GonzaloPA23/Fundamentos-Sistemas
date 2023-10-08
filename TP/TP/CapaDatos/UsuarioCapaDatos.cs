using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using CapaEntidad;
using System.Net;

namespace CapaDatos
{
    public class UsuarioCapaDatos
    {
        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadenaConexion))
            {
                try
                {
                    string query = "SELECT id,dni,nombre,apellido,clave,correo FROM usuario";
                    SqlCommand comando = new SqlCommand(query,oconexion);
                    comando.CommandType = CommandType.Text;
                    oconexion.Open();
                    using(SqlDataReader odr = comando.ExecuteReader())
                    {
                        while (odr.Read())
                        {
                            Usuario usuario = new Usuario();
                            usuario.Id = Convert.ToInt32(odr["id"]);
                            usuario.Dni = odr["dni"].ToString();
                            usuario.Nombre = odr["nombre"].ToString();
                            usuario.Apellido = odr["apellido"].ToString();
                            usuario.Clave = odr["clave"].ToString();
                            usuario.Correo = odr["correo"].ToString();
                            usuarios.Add(usuario);
                        }
                    }
                }catch 
                {
                    usuarios = new List<Usuario>();
                }
                return usuarios;
            }
        }

        public int RegistrarUsuario(Usuario usuario, out string mensaje)
        {
            int idusuariogenerado = 0;
            mensaje = string.Empty;
            try
            {
                using(SqlConnection oconexion = new SqlConnection(Conexion.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarUsuario", oconexion);
                    cmd.Parameters.AddWithValue("dni", usuario.Dni);
                    cmd.Parameters.AddWithValue("nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("clave", usuario.Clave);
                    cmd.Parameters.AddWithValue("correo", usuario.Correo);
                    cmd.Parameters.Add("idResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idusuariogenerado = Convert.ToInt32(cmd.Parameters["idResultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idusuariogenerado = 0;
                mensaje = ex.Message;
            }

            return idusuariogenerado;
        }
    }
}
