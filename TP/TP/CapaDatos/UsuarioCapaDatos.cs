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
                }catch (Exception e)
                {
                    usuarios = new List<Usuario>();
                }
                return usuarios;
            }
        }
    }
}
