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
    public partial class frmBus : Form
    {
        private ChoferCapaNegocio choferCapaNegocio = new ChoferCapaNegocio();
        public frmBus()
        {
            InitializeComponent();
            MostrarChoferes(choferCapaNegocio.ListarChoferes());
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
        }
    }
}
