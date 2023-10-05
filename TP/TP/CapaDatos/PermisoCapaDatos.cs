using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Globalization;

namespace CapaDatos
{
    public class PermisoCapaDatos
    {
        public List<Permiso> ListarPermisos(int idUsuario)
        {
            List<Permiso> permisos = new List<Permiso>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadenaConexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT permiso.rol_id,nombre_menu FROM permiso");
                    query.AppendLine("JOIN rol r2 ON r2.id = permiso.rol_id");
                    query.AppendLine("JOIN usuario u ON r2.id = u.rol_id");
                    query.AppendLine("WHERE u.id = @idUsuario");

                    SqlCommand comando = new SqlCommand(query.ToString(), oconexion);
                    comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                    comando.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader odr = comando.ExecuteReader())
                    {
                        while (odr.Read())
                        {
                            permisos.Add(new Permiso()
                            {
                                ObjRol = new Rol() { Id = Convert.ToInt32(odr["rol_id"]) },
                                NombreMenu = odr["nombre_menu"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception e)
                {
                    
                    permisos = new List<Permiso>();
                }
                return permisos;
            }
        }
    }
}
