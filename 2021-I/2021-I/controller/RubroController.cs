using _2021_I.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_I.controller
{
    class RubroController
    {
        private static List<Rubro> rubros = new List<Rubro>();
        public RubroController() { }
        public bool Existe(String codigo)
        {
            return rubros.Exists(r => r.Codigo.Equals(codigo));
        }
        public void Registrar(Rubro rubro)
        {
            rubros.Add(rubro);
        }
        public static List<Rubro> ListarTodo()
        {
            return rubros;
        }
        public List<Rubro>ListarRubrosConMasRegistros6Meses()
        {
            List<Rubro> rubroTemp = new List<Rubro>();
            int contMaxRegistros = 0;

            foreach(Rubro r in rubros)
            {
                int contEmpresas = r.Empresas.Count(e => e.Fecha >= new DateTime(2023, 05, 01));

                if(contEmpresas > contMaxRegistros)
                {
                    rubroTemp.Clear();
                    contMaxRegistros = contEmpresas;
                    rubroTemp.Add(r);
                }
                else if (contEmpresas == contMaxRegistros)
                {
                    rubroTemp.Add(r);
                }
            }
            return rubroTemp;
        }
        public double TamañoPromedioRubrosMenorMedianasEmpresas()
        {
            int contMinEmpresas = 1000;
            int contRubros = 0;
            int sumTamanio = 0;

            foreach (Rubro r in rubros)
            {
                int contEmpresas = r.Empresas.Count(e => e.Tamanio.Equals("Medianas"));

                if (contEmpresas < contMinEmpresas)
                {
                    contMinEmpresas = contEmpresas;
                    sumTamanio = r.Empresas.Count();
                    contRubros = 1;
                }
                else if (contEmpresas == contMinEmpresas)
                {
                    contRubros++;
                    sumTamanio += r.Empresas.Count();
                }
            }

            return (double)sumTamanio / contRubros;
        }
    }
}
