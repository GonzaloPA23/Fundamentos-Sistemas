using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class frmChofer : Form
    {
        private ChoferCapaNegocio choferCapaNegocio = new ChoferCapaNegocio();
        public frmChofer()
        {
            InitializeComponent();
            MostrarChoferes(choferCapaNegocio.ListarChoferes());
        }

        private void LimpiarCampos()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpFechaNacimiento.Text = DateTime.Now.ToString();
            txtCelular.Text = "";
            txtCorreo.Text = "";
        }

        private void MostrarChoferes(List<Chofer> lista)
        {
            listViewChoferes.Items.Clear();
            foreach (Chofer chofer in lista)
            {
                ListViewItem fila = new ListViewItem(chofer.Dni);
                fila.SubItems.Add(chofer.Nombre);
                fila.SubItems.Add(chofer.Apellido);
                fila.SubItems.Add(chofer.Celular);
                fila.SubItems.Add(chofer.Correo);
                fila.SubItems.Add(chofer.FechaNacimiento.ToString("dd/MM/yyyy"));
                listViewChoferes.Items.Add(fila);
            }

            lblTotalChoferes.Text = lista.Count.ToString();
        }

        private void btnCancelarChofer_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnRegistrarChofer_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Chofer chofer = new Chofer()
            {
                Dni = txtDni.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Celular = txtCelular.Text,
                Correo = txtCorreo.Text
            };

            int idchofergenerado = new ChoferCapaNegocio().RegistrarChofer(chofer, out mensaje);

            if (idchofergenerado != 0)
            {
                MessageBox.Show("Chofer registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                MostrarChoferes(choferCapaNegocio.ListarChoferes());
            }
            else MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            MostrarChoferes(choferCapaNegocio.ListarChoferes());
        }
    }
}
