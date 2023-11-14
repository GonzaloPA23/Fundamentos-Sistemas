using CapaDatos;
using CapaNegocio;
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
            string mensaje = string.Empty; 

            Usuario usuario = new Usuario()
            {
                Dni = txtDni.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Clave = txtClave.Text,
                Correo = txtCorreo.Text
            };
            int idUsuarioGenerado = new NUsuario().RegistrarUsuario(usuario, out mensaje);
            if (idUsuarioGenerado != 0)
            {
                MessageBox.Show("Usuario registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                frmIniciarSesion frmIniciarSesion = new frmIniciarSesion();
                frmIniciarSesion.Show();
                this.Hide();
                frmIniciarSesion.FormClosing += Form_Closing;
            }else MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
