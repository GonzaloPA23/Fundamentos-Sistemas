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
    public partial class FormRubro : Form
    {
        private RubroReport rR = new RubroReport();
        public FormRubro()
        {
            InitializeComponent();
            MostrarRubros(rR.ListarTodo());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarRubros(List<Rubro>lst)
        {
            listViewRubros.Items.Clear();
            foreach(Rubro r in lst)
            {
                ListViewItem fila = new ListViewItem(r.Codigo);
                fila.SubItems.Add(r.Nombre);
                fila.SubItems.Add(r.Descripcion);
                fila.SubItems.Add(r.Prioridad);
                listViewRubros.Items.Add(fila);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == "" || txtPrioridad.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Rubro rubro = new Rubro()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Prioridad = txtPrioridad.Text,
                Empresas = new List<Empresa>()
            };

            if (!rR.Registrar(rubro))
            {
                MessageBox.Show("Este código ya existe");
                return;
            }

            MostrarRubros(rR.ListarTodo());
        }

        private void btnVerEmpresas_Click(object sender, EventArgs e)
        {
            if (listViewRubros.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un código.");
                return;
            }

            FormEmpresa frm = new FormEmpresa(listViewRubros.SelectedItems[0].Text);
            frm.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormReporte frm = new FormReporte();
            frm.Show();
        }
    }
}
