using _2021_I.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_I.controller
{
    class EmpresaController
    {

        public EmpresaController() { }
        public bool Existe(String ruc)
        {
            List<Rubro> rubros = RubroController.ListarTodo();
            
            foreach(Rubro r in rubros)
            {
                bool existe = r.Empresas.Exists(e => e.Ruc.Equals(ruc));
                if(existe)
                {
                    return true;
                }
            }
            return false;
        }
        public void Registrar(String codigo, Empresa empresa)
        {
            List<Rubro> rubros = RubroController.ListarTodo();
            Rubro rubro = rubros.Find(r => r.Codigo.Equals(codigo));

            if (rubro != null)
            {
                rubro.Empresas.Add(empresa);
            }
        }
        public List<Empresa> ListarTodo(String codigo)
        {
            List<Rubro> rubros = RubroController.ListarTodo();
            Rubro rubro = rubros.Find(r => r.Codigo.Equals(codigo));

            if (rubro != null)
            {
                return rubro.Empresas;
            }
            else
            {
                return new List<Empresa>();
            }
        }
        public List<Empresa> ListarEmpresasEvaluacion()
        {
            List<Rubro> rubros = RubroController.ListarTodo();
            List<Empresa> empresasTemp = new List<Empresa>();
            foreach (Rubro r in rubros)
            {

                if (r.Empresas.Exists(e => e.Estado.Equals("Evaluacion")))
                {
                    empresasTemp.AddRange(r.Empresas.FindAll(e => e.Estado.Equals("Evaluacion")));
                }
            }
            return empresasTemp;
        }
        public List<String> ListarDistritosMasEmpresas()
        {
            List<String> distritos = new List<String>();

            int SI = 0;
            int SB = 0;
            int JM = 0;
            int B = 0;
            int CL = 0;

            List<Rubro> rubros = RubroController.ListarTodo();
            foreach(Rubro r in rubros)
            {
                foreach(Empresa e in r.Empresas)
                {
                    if (e.Distrito.Equals("San Isidro")) SI++;
                    else if (e.Distrito.Equals("San Borja")) SB++;
                    else if (e.Distrito.Equals("Jesus Maria")) JM++;
                    else if (e.Distrito.Equals("Breña")) B++;
                    else if (e.Distrito.Equals("Cercado de Lima")) CL++;
                }
            }

            int[] arrayCont = { SI, SB, JM, B, CL };
            int maxCont = 0;
            for(int i = 0; i < arrayCont.Length; i++)
            {
                if (arrayCont[i] > maxCont)
                {
                    distritos.Clear();
                    maxCont = arrayCont[i];
                    switch(i)
                    {
                        case 0: distritos.Add("San Isidro");
                            break;
                        case 1:
                            distritos.Add("San Borja");
                            break;
                        case 2:
                            distritos.Add("Jesus Maria");
                            break;
                        case 3:
                            distritos.Add("Breña");
                            break;
                        case 4:
                            distritos.Add("Cercado de Lima");
                            break;
                    }

                }
                else if (arrayCont[i] == maxCont)
                {
                    switch (i)
                    {
                        case 0:
                            distritos.Add("San Isidro");
                            break;
                        case 1:
                            distritos.Add("San Borja");
                            break;
                        case 2:
                            distritos.Add("Jesus Maria");
                            break;
                        case 3:
                            distritos.Add("Breña");
                            break;
                        case 4:
                            distritos.Add("Cercado de Lima");
                            break;
                    }
                }
            }

            return distritos;
        }
    }
}
