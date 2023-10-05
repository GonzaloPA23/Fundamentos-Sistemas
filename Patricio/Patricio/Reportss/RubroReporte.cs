using Patricio.Controller;
using Patricio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patricio.Reports.cs
{
    internal class RubroReport
    {
        private RubroController rC = new RubroController();
        public RubroReport() { }

        public bool Registrar(Rubro rubro)
        {
            if (rC.Existe(rubro.Codigo))
            {
                return false;
            }
            else
            {
                rC.Registrar(rubro);
                return true;
            }
        }

        public List<Rubro> ListarTodo()
        {
            return RubroController.ListarTodo();
        }
        public List<Rubro> ListarRubrosConMasRegistros6Meses()
        {
            return rC.ListarRubrosConMasRegistros6Meses();
        }
        public double TamañoPromedioRubrosMenorMedianasEmpresas()
        {
            return rC.TamañoPromedioRubrosMenorMedianasEmpresas();
        }
    }
}
