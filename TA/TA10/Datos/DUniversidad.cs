using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DUniversidad
    {
        public String Registrar(Universidad universidad)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Universidad.Add(universidad);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Universidad universidad)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Universidad universidadTemp = context.Universidad.Find(universidad.Id_universidad);
                    universidadTemp.Nombre = universidad.Nombre;
                    universidadTemp.Ruc = universidad.Ruc;
                    context.SaveChanges();
                }
                return "Universidad modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Universidad universidadTemp = context.Universidad.Find(id);
                    context.Universidad.Remove(universidadTemp);
                    context.SaveChanges();
                }
                return "Universidad y dependencias eliminadas correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Universidad> ListarTodo()
        {
            List<Universidad> universidades = new List<Universidad>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    universidades = context.Universidad.ToList();
                }
                return universidades;
            }
            catch (Exception ex)
            {
                return universidades;
            }
        }
    }
}
