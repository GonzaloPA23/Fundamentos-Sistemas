using CapaEntidad;
using CapaPresentacion;

namespace TP
{
    public partial class frmInicio : Form
    {
        private static Usuario usuarioActual;

        public frmInicio(Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            lblNombreUsuarioIngresado.Text = usuarioActual.Nombre + " " + usuarioActual.Apellido;
        }

        private void menuchoferes_Click(object sender, EventArgs e)
        {
            frmChofer frmChofer = new frmChofer();
            frmChofer.TopLevel = false;
            frmChofer.FormBorderStyle = FormBorderStyle.None;
            frmChofer.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(frmChofer);
            frmChofer.Show();
        }
    }
}