using Patricio.Controller;
using Patricio.Entities;
using Patricio.Reports;
using Patricio.Reports.cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patricio
{
    public partial class FormEmpresa : Form
    {
        private EmpresaReport eR = new EmpresaReport();
        private String codigo;
        public FormEmpresa(String codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            MostrarEmpresas(eR.ListarTodo(codigo));
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
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtRuc.Text == "" || txtNombre.Text == "" || txtCelular.Text == "" || cbDistrito.Text == "" || txtDireccion.Text == "" || txtFecha.Text == "" || cbTamanio.Text == "" || cbEstado.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            string fecha = txtFecha.Text;
            int anio = int.Parse(fecha.Substring(0, 4));
            int mes = int.Parse(fecha.Substring(4, 2));
            int dia = int.Parse(fecha.Substring(6, 2));

            Empresa empresa = new Empresa()
            {
                Ruc = txtRuc.Text,
                Nombre = txtNombre.Text,
                Celular = txtCelular.Text,
                Distrito = cbDistrito.Text,
                Direccion = txtDireccion.Text,
                Fecha = new DateTime(anio, mes, dia),
                Tamanio = cbTamanio.Text,
                Estado = cbEstado.Text
            };

            if (!eR.Registrar(codigo, empresa))
            {
                MessageBox.Show("El código ya existe");
                return;
            }

            MostrarEmpresas(eR.ListarTodo(codigo));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
