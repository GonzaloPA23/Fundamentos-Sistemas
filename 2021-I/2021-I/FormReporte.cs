using _2021_I.entities;
using _2021_I.reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_I
{
    public partial class FormReporte : Form
    {
        private RubroReport rR = new RubroReport();
        private EmpresaReport eR = new EmpresaReport();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarRubros(List<Rubro> lst)
        {
            listViewRubros.Items.Clear();
            foreach (Rubro r in lst)
            {
                ListViewItem fila = new ListViewItem(r.Codigo);
                fila.SubItems.Add(r.Nombre);
                fila.SubItems.Add(r.Descripcion);
                fila.SubItems.Add(r.Prioridad);
                listViewRubros.Items.Add(fila);
            }
        }

        private void MostrarEmpresas(List<Empresa> lst)
        {
            listViewEmpresas.Items.Clear();
            foreach (Empresa e in lst)
            {
                ListViewItem fila = new ListViewItem(e.Ruc);
                fila.SubItems.Add(e.Nombre);
                fila.SubItems.Add(e.Celular);
                fila.SubItems.Add(e.Distrito);
                fila.SubItems.Add(e.Fecha.ToString());
                fila.SubItems.Add(e.Tamanio);
                fila.SubItems.Add(e.Estado);
                listViewEmpresas.Items.Add(fila);
            }
        }

        private void btnRubrosConMasEmpresas6Meses_Click(object sender, EventArgs e)
        {
            MostrarRubros(rR.ListarRubrosConMasRegistros6Meses());
        }

        private void btnEmpresasEvaluacion_Click(object sender, EventArgs e)
        {
            MostrarEmpresas(eR.ListarEmpresasEvaluacion());
        }

        private void btnCalularPromedio_Click(object sender, EventArgs e)
        {
            lbTamañoPromedioRubrosMenorEmpresasMedianas.Text= rR.TamañoPromedioRubrosMenorMedianasEmpresas().ToString();
        }

        private void MostrarDistritos(List<String>lst)
        {
            listViewDistritos.Items.Clear();
            foreach(String s in lst)
            {
                ListViewItem fila = new ListViewItem(s);
                listViewDistritos.Items.Add(fila);
            }
        }
        private void btnDistritoMasEmpresas_Click(object sender, EventArgs e)
        {
            MostrarDistritos(eR.ListarDistritosMasEmpresas());
        }
    }
}
