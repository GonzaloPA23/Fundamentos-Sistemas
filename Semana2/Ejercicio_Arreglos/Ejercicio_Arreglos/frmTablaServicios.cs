using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Arreglos
{
    public partial class frmTablaServicios : Form
    {
        Form1 form1 = new Form1();
        Array registros;
        public frmTablaServicios(Array registros)
        {
            this.registros = registros;
            InitializeComponent();
        }

        private void frmTablaServicios_Load(object sender, EventArgs e)
        {

        }

        // Propiedad para acceder al ListView desde el Form1
        public ListView listView
        {
            get { return listView1; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String name = listView1.SelectedItems[0].Text;
            int pos =Array.IndexOf(registros, name);

            // Eliminar el registro
            int contador = 0;
            foreach (ModelRegister registro in registros)
            {
                if (registro == null) contador++;
            }

            for (int i = 0; i < contador; i++)
            {
                if (i >= pos)
                {
                    registros.SetValue(registros.GetValue(i + 1), i);
                }
            }

            form1.mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.ordenar();
        }
    }
}
