using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class frmPago : Form
    {
        public frmPago()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado emple = new Empleado();
            emple.Nombre = textBoxNombres.Text;
            emple.Categoria = comboBoxCategoria.Text;
            emple.MinutosTardanza = int.Parse(textBoxMinutosTardanza.Text);
            emple.LlamadasAtencion = int.Parse(textBoxLlamadasAtencion.Text);

            switch (emple.Categoria)
            {
                case "A": emple.Pago = 2500; break;
                case "B": emple.Pago = 2000; break;
                case "C": emple.Pago = 1500; break;
                case "D": emple.Pago = 900; break;
            }

            if (emple.MinutosTardanza == 0 && emple.LlamadasAtencion == 0)
            {
                emple.Pago = emple.Pago + emple.Pago * 0.15;

            }
            else
            {
                double descuentosMinutosTardanza = emple.MinutosTardanza * 5;
                double descLlamadasAtencion = emple.LlamadasAtencion * 10;
                emple.Pago = emple.Pago - descuentosMinutosTardanza - descLlamadasAtencion;
            }



            /*ListViewItem.ListViewSubItem[] subItems = new ListViewItem.ListViewSubItem[3];
            subItems[0] = new ListViewItem.ListViewSubItem();
            subItems[0].Text = emple.Nombre;
            subItems[0].BackColor = Color.Lavender;

            subItems[1] = new ListViewItem.ListViewSubItem();
            subItems[1].Text = emple.Pago.ToString();
            subItems[1].BackColor = Color.Blue;

            subItems[2] = new ListViewItem.ListViewSubItem();
            subItems[2].Text = emple.LlamadasAtencion.ToString();

            ListViewItem fila2 = new ListViewItem(subItems, 0);
            listView1.Items.Add(fila2);*/

            ListViewItem fila = new ListViewItem(emple.Nombre);
            fila.SubItems.Add(emple.Categoria);
            fila.SubItems.Add(emple.MinutosTardanza.ToString());
            fila.SubItems.Add(emple.LlamadasAtencion.ToString());
            fila.SubItems.Add(emple.Pago.ToString());



            listView1.Items.Add(fila);

            if (lbTotal.Text == "")
            {
                lbTotal.Text = "1";
            }
            else
            {
                lbTotal.Text = (int.Parse(lbTotal.Text) + 1).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPago_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
