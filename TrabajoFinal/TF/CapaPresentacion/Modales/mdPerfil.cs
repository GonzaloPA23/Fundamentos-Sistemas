using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion.Modales
{
    public partial class mdPerfil : Form
    {
        private Usuario usuario;
        private NUsuario nUsuario = new NUsuario();
        public mdPerfil(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void mdPerfil_Load(object sender, EventArgs e)
        {
           
            if (usuario.Foto != null)
            {
                pbFotoPerfil.Image = ByteToImage(usuario.Foto);
                pbFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                pbFotoPerfil.Visible = true;
            }
            else
            {
                pbFotoPerfil.Visible = false;
            }
            tbNombre.Text = usuario.Nombre;
            tbApellido.Text = usuario.Apellido;
            tbCorreo.Text = usuario.Correo;
            tbDNI.Text = usuario.Dni;
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {

                byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = nUsuario.ActualizarFoto(usuario.Id,byteimage, out mensaje);

                if (respuesta)
                    pbFotoPerfil.Image = ByteToImage(byteimage);
                else
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
