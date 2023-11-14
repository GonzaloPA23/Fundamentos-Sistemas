using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DUsuario
    {
        // Constructor vacío
        public DUsuario() { }
        // Metodo para listar los usuarios
        public List<Usuario> ListarUsuarios()
        {
            using(var context = new DB_PerlaAltomayoEntities())
            {
                try
                {
                    return context.Usuario.ToList();
                }
                catch (Exception e)
                {
                    return new List<Usuario>();
                }
            }
        }
        // Metodo para registrar un usuario mediante stored procedure
        public int RegistrarUsuario(Usuario usuario, out string mensaje)
        {
            int idusuariogenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (var context = new DB_PerlaAltomayoEntities())
                {
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Dni", usuario.Dni),
                        new SqlParameter("@Nombre", usuario.Nombre),
                        new SqlParameter("@Apellido", usuario.Apellido),
                        new SqlParameter("@Clave", usuario.Clave),
                        new SqlParameter("@Correo", usuario.Correo),
                        new SqlParameter("@IdResultado", SqlDbType.Int) { Direction = ParameterDirection.Output },
                        new SqlParameter("@Mensaje", SqlDbType.VarChar, 200) { Direction = ParameterDirection.Output }
                    };
                    context.Database.ExecuteSqlCommand("EXEC SP_RegistrarUsuario @Dni, @Nombre, @Apellido, @Clave, @Correo, @IdResultado OUTPUT, @Mensaje OUTPUT", parameters);
                    idusuariogenerado = Convert.ToInt32(parameters.Single(p => p.ParameterName == "@IdResultado").Value);
                    mensaje = parameters.Single(p => p.ParameterName == "@Mensaje").Value.ToString();
                }
            }catch (Exception ex)
            {
                idusuariogenerado = 0;
                mensaje = ex.Message;
            }
            return idusuariogenerado;
        }

    }
}