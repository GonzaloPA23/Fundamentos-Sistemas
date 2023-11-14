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
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmBus : Form
    {
        private NChofer nChofer = new NChofer();
        public frmBus()
        {
            InitializeComponent();
            MostrarChoferes(nChofer.ListarChoferes());
        }

        private void MostrarChoferes(List<Chofer> choferes)
        {
            dgChoferes.Rows.Clear();
            foreach (Chofer chofer in choferes)
            {
                dgChoferes.Rows.Add(new object[] { "", chofer.Id, chofer.Dni, chofer.Nombre,
                    chofer.Apellido, chofer.Celular, chofer.Correo,
                    chofer.FechaNacimiento.ToString("yyyy-MM-dd") });
            }
            lblTotalChoferes.Text = choferes.Count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgChoferes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return; // cabezera del datagridview
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}
