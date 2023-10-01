using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmIniciarSesion frmIniciarSesion = new frmIniciarSesion();
            frmIniciarSesion.Show();
            this.Hide();
            frmIniciarSesion.FormClosing += Form_Closing;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtClave.Text = "";
            txtCorreo.Text = "";
            txtDni.Text = "";
            this.Show();
        }
    }
}
