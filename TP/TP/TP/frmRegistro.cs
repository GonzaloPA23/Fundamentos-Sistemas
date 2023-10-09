using CapaEntidad;
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

        private void label8_Click(object sender, EventArgs e)
        {
            frmIniciarSesion frmIniciarSesion = new frmIniciarSesion();
            frmIniciarSesion.Show();
            this.Hide();
            frmIniciarSesion.FormClosing += Form_Closing;
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
                Correo = txtCorreo.Text,
                ObjRol = new Rol()
            };

            int idusuariogenerado = new UsuarioCapaNegocio().RegistrarUsuario(usuario, out mensaje);
            if (idusuariogenerado != 0)
            {
                MessageBox.Show("Usuario registrado correctamente","Éxito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LimpiarCampos();
                frmIniciarSesion frmIniciarSesion = new frmIniciarSesion();
                frmIniciarSesion.Show();
                this.Hide();
                frmIniciarSesion.FormClosing += Form_Closing;
            }
            else MessageBox.Show(mensaje,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtClave.Text = "";
            txtCorreo.Text = "";
            txtDni.Text = "";
        }
    
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            LimpiarCampos();
            this.Show();
        }
    }
}
