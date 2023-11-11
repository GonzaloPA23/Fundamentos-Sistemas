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

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmIniciarSesion frmIniciarSesion = new frmIniciarSesion();
            frmIniciarSesion.Show();
            this.Hide();
            frmIniciarSesion.FormClosing += Form_Closing;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtDni.Clear();
            txtClave.Clear();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            LimpiarCampos();
            this.Show();
        }
    }
}
