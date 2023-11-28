using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCliente
    {
        public List<CLIENTE> ListarClientes()
        {
            List<CLIENTE> clientes = new List<CLIENTE>();
            try
            {
                using (var context = new dbCasaEmpenioEntities())
                {
                    clientes = context.CLIENTE.ToList();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }
        }
    }
}
