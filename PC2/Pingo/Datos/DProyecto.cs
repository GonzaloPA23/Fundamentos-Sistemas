using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProyecto
    {
        // Constructor vacio
        public DProyecto() { }
        // Metodo Registrar un proyecto
        public String Registrar(Proyectos proyecto)
        {
            try
            {
                using (var context = new dbGestionProyectosEF())
                {
                    context.Proyectos.Add(proyecto);
                    context.SaveChanges();
                }
                return "Proyecto registrado con exito";
            }
            catch (Exception ex)
            {
                return "Error al registrar el proyecto: " + ex.Message;
            }
        }
        // Metodo Modificar un proyecto
        public String Modificar(Proyectos proyecto)
        {
            try
            {
                using (var context = new dbGestionProyectosEF())
                {
                    context.Entry(proyecto).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                return "Proyecto modificado con exito";
            }
            catch (Exception ex)
            {
                return "Error al modificar el proyecto: " + ex.Message;
            }
        }
        // Metodo Eliminar un proyecto
        public String Eliminar(int id)
        {
            try
            {
                using(var context = new dbGestionProyectosEF())
                {
                    var proyecto = context.Proyectos.Find(id);
                    context.Proyectos.Remove(proyecto);
                    context.SaveChanges();
                }
                return "Proyecto eliminado con exito";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el proyecto: " + ex.Message;
            }
        }
        // Metodo para Listar los proyectos
        public List<Proyectos> ListarTodo()
        {
            List<Proyectos> proyectos = new List<Proyectos>();
            try
            {
                using (var context = new dbGestionProyectosEF())
                {
                    proyectos = context.Proyectos.ToList();
                }
                return proyectos;
            }
            catch (Exception ex)
            {
                return proyectos;
            }
        }
    }
}

