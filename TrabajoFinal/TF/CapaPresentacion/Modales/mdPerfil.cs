using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion.Modales
{
    public partial class mdPerfil : Form
    {
        private Usuario usuario;
        public mdPerfil(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void mdPerfil_Load(object sender, EventArgs e)
        {
            tbNombre.Text = usuario.Nombre;
            tbApellido.Text = usuario.Apellido;
            tbCorreo.Text = usuario.Correo;
            tbDNI.Text = usuario.Dni;
        }
    }
}
