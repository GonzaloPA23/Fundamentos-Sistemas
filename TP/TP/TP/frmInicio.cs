using CapaEntidad;

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
    }
}