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
    public partial class FormReportePersonaje : Form
    {
        private PersonajeService? personajeService;
        public FormReportePersonaje()
        {

            InitializeComponent();
            personajeService = new();
            Mostrar(personajeService.ListarTodo());
        }

        private void Mostrar(List<Personaje> lista)
        {
            listViewPersonajes.Items.Clear();
            foreach (Personaje personaje in lista)
            {
                ListViewItem fila = new(personaje.Codigo);
                fila.SubItems.Add(personaje.NombrePersonaje);
                fila.SubItems.Add(personaje.NombreActor);
                fila.SubItems.Add(personaje.Genero);
                fila.SubItems.Add(personaje.MinutosAparicion.ToString());
                listViewPersonajes.Items.Add(fila);
            }
        }

        private void btnBuscarXCodigoPelicula_Click(object sender, EventArgs e)
        {
            // Verificar que el código de película no esté vacío
            if (tbBuscarXCodigoPelicula.Text == "")
            {
                MessageBox.Show("Debe ingresar un código de película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            personajeService = new PersonajeService(tbBuscarXCodigoPelicula.Text);
            lblPersonajesMas40MinutosAparicion.Text = personajeService.ListarPorCodigoPeliculaMasDe40Minutos().Count.ToString();
            //Mostrar en el listView
            Mostrar(personajeService.ListarPorCodigoPeliculaMasDe40Minutos());
        }

        private void btnBuscarXGeneroPersonaje_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (cbBuscarXGeneroPersonaje.Text == "")
            {
                MessageBox.Show("Debe ingresar un género", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(cbBuscarXGeneroPersonaje.Text.Contains("masculino") || cbBuscarXGeneroPersonaje.Text.Contains("Masculino") || cbBuscarXGeneroPersonaje.Text.Contains("femenino") || cbBuscarXGeneroPersonaje.Text.Contains("Femenino") ||
                cbBuscarXGeneroPersonaje.Text.Contains("no definido") || cbBuscarXGeneroPersonaje.Text.Contains("No definido")))
            {
                MessageBox.Show("Debe ingresar un género correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Mostrar en el listView
            Mostrar(lista: personajeService.ListarPorGeneroPersonaje(cbBuscarXGeneroPersonaje.Text));
        }
    }
}
