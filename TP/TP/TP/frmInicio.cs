using CapaEntidad;
using CapaPresentacion;
using FontAwesome.Sharp;
using CapaNegocio;
namespace TP
{
    public partial class frmInicio : Form
    {
        private static Usuario? usuarioActual;
        private static IconMenuItem? menuActivo = null;
        private static Form? formularioActivo = null;

        public frmInicio(Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            List<Permiso> permisos = new PermisoCapaNegocio().ListarPermisos(usuarioActual.Id);
            foreach (IconMenuItem iconMenu in menuStrip1.Items)
            {
                bool encontrado = permisos.Any(m => m.NombreMenu.Equals(iconMenu.Name));
                if (!encontrado) { iconMenu.Visible = false; }
            }

            lblNombreUsuarioIngresado.Text = usuarioActual.Nombre + " " + usuarioActual.Apellido;
        }

        private void AbrirFormularioHijo(IconMenuItem iconMenuItem, Form form)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }
            iconMenuItem.BackColor = Color.FromArgb(245, 210, 222);
            menuActivo = iconMenuItem;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.FromArgb(235, 235, 233);
            panelContenedor.Controls.Add(form);
            form.Show();
        }

        private void menuchoferes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo((IconMenuItem)sender, new frmChofer());
        }

        private void menubuses_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo((IconMenuItem)sender, new frmBus());
        }

        private void menupasajes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo((IconMenuItem)sender, new frmPasaje());
        }

        private void menuencomiendas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo((IconMenuItem)sender, new frmEncomienda());
        }

        private void subMenuHistorialPasajes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(menureportes, new frmHistorialEncomienda());
        }

        private void subMenuHistorialEncomiendas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(menureportes, new frmHistorialEncomienda());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}