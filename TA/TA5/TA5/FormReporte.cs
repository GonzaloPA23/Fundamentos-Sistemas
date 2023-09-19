using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA5.entities;
using TA5.services;

namespace TA5
{
    public partial class FormReporte : Form
    {
        private PeliculaService peliculaService = new();
        public FormReporte()
        {
            InitializeComponent();
        }
        private void Mostrar(List<Pelicula> lista)
        {
            listView1.Items.Clear();
            foreach (Pelicula pelicula in lista)
            {
                ListViewItem fila = new(pelicula.Codigo);
                fila.SubItems.Add(pelicula.Nombre);
                fila.SubItems.Add(pelicula.Pais);
                fila.SubItems.Add(pelicula.Genero);
                fila.SubItems.Add(pelicula.DuracionMinutos.ToString());
                listView1.Items.Add(fila);
            }
            listView1.Text = lista.Count.ToString();
        }

        private void btnBuscarXGeneroPelicula_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (cbBuscarXGeneroPelicula.Text == "")
            {
                MessageBox.Show("Debe ingresar un género", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Mostrar en el listview
            Mostrar(peliculaService.ListarPorGenero(cbBuscarXGeneroPelicula.Text));
        }

        private void btnBuscarXNombreActor_Click(object sender, EventArgs e)
        {
            if (tbBuscarXNombreActor.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de actor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Mostrar(peliculaService.ListarPorNombreActor(tbBuscarXNombreActor.Text));
        }

        private void btnBuscarMenorCantidadPersonajesFemenino_Click(object sender, EventArgs e)
        {
            Mostrar(peliculaService.ListarPorMenosPersonajesFemeninos());
        }
    }
}
