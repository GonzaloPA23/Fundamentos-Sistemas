using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP;

namespace CapaPresentacion
{
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Show();
            this.Hide();
            frmRegistro.FormClosing += FrmClosing;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
            this.Hide();
            frmInicio.FormClosing += FrmClosing;

        }

        private void FrmClosing(object sender, FormClosingEventArgs e)
        {
            txtClave.Text = "";
            txtDni.Text = "";
            this.Show();
        }
    }
}
