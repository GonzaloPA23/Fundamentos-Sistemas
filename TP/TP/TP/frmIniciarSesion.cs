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
using CapaNegocio;
using CapaEntidad;

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
            List<Usuario> test = new UsuarioCapaNegocio().ListarUsuarios();
            Usuario? usuario = new UsuarioCapaNegocio().ListarUsuarios().Where(u => u.Dni == txtDni.Text && u.Clave == txtClave.Text).FirstOrDefault();

            if (usuario != null)
            {
                frmInicio frmInicio = new frmInicio(usuario);
                frmInicio.Show();
                this.Hide();
                frmInicio.FormClosing += FrmClosing;
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas, Por favor, Ingrese los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmClosing(object sender, FormClosingEventArgs e)
        {
            txtClave.Text = "";
            txtDni.Text = "";
            this.Show();
        }
    }
}
