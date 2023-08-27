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
        public frmTablaServicios()
        {
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
    }
}
