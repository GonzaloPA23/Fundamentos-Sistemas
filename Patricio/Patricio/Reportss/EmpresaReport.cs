using Patricio.Controller;
using Patricio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patricio.Reports.cs
{
    internal class EmpresaReport
    {
        private EmpresaController eC = new EmpresaController();
        public EmpresaReport() { }
        public bool Registrar(String codigo, Empresa empresa)
        {
                if (eC.Existe(empresa.Ruc))
                {
                    return false;
                }
                else
                {
                    eC.Registrar(codigo, empresa);
                    return true;
                }
        }
            public List<Empresa> ListarTodo(String codigo)
            {
                return eC.ListarTodo(codigo);
            }
            public List<Empresa> ListarEmpresasEvaluacion()
            {
                return eC.ListarEmpresasEvaluacion();
            }
            public List<String> ListarDistritosMasEmpresas()
            {
                return eC.ListarDistritosMasEmpresas();
            }
    }
}

