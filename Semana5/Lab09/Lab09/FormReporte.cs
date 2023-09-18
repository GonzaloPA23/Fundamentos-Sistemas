using Lab09.Entities;
using Lab09.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09
{
    public partial class FormReporte : Form
    {
        private EntrenadorService eS = new();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mostrar(List<Entrenador> lista)
        {
            listViewEntrenador.Items.Clear();
            foreach (Entrenador en in lista)
            {
                ListViewItem fila = new(en.Codigo);
                fila.SubItems.Add(en.Nombre);
                fila.SubItems.Add(en.Edad.ToString());
                fila.SubItems.Add(en.Region);
                listViewEntrenador.Items.Add(fila);
            }
            lblTotalEntrenadores.Text = lista.Count.ToString();
        }

        private void btnBuscarXNombrePokemon_Click(object sender, EventArgs e)
        {
            // Validación de campo
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del pokemon");
                return;
            }

            // Mostrar en el listview
            Mostrar(eS.ListarPorNombrePokemon(tbNombre.Text));
        }

        private void btnBuscarPorRegion_Click(object sender, EventArgs e)
        {
            if (cbRegion.Text == "")
            {
                MessageBox.Show("Ingrese la región del pokemon");
                return;
            }

            // Mostrar en el listview
            Mostrar(eS.ListarPorRegion(cbRegion.Text));
        }

        private void btnBuscarEntrenadoresPorMenosPokemons_Click(object sender, EventArgs e)
        {
            Mostrar(eS.ListarPorMenosPokemons());
        }
    }
}
