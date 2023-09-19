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
    public partial class FormPelicula : Form
    {
        private PeliculaService peliculaService = new();
        public FormPelicula()
        {
            InitializeComponent();
            Mostrar(peliculaService.ListarTodo());
        }

        private void Mostrar(List<Pelicula> lista)
        {
            listViewPeliculas.Items.Clear();
            foreach (Pelicula pelicula in lista)
            {
                ListViewItem fila = new(pelicula.Codigo);
                fila.SubItems.Add(pelicula.Nombre);
                fila.SubItems.Add(pelicula.Pais);
                fila.SubItems.Add(pelicula.Genero);
                fila.SubItems.Add(pelicula.DuracionMinutos.ToString());
                listViewPeliculas.Items.Add(fila);
            }
            lblTotalPeliculas.Text = lista.Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if(listViewPeliculas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormPersonaje formPersonaje = new FormPersonaje(listViewPeliculas.SelectedItems[0].Text);
            formPersonaje.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbPais.Text == "" || cbGenero.Text == "" || nudDuracionEnMinutos.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verificación de datos correctos para los campos
            if (!(cbGenero.Text.Contains("comedia") || cbGenero.Text.Contains("Comedia") || cbGenero.Text.Contains("Drama") || cbGenero.Text.Contains("drama")
               || cbGenero.Text.Contains("Ciencia Ficcion") || cbGenero.Text.Contains("ciencia ficcion") || cbGenero.Text.Contains("terror") || cbGenero.Text.Contains("Terror")
               || cbGenero.Text.Contains("Anime") || cbGenero.Text.Contains("anime")))
            {
                // Message error data incorrect
                MessageBox.Show("Debe ingresar un género correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Crear el objeto
            Pelicula pelicula = new()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Pais = tbPais.Text,
                Genero = cbGenero.Text,
                DuracionMinutos = int.Parse(nudDuracionEnMinutos.Text),
                Personajes = new()
            };
            // Insertar el objeto en la lista
            bool insertado = peliculaService.InsertarPelicula(pelicula);
            if (!insertado) 
            {                 
                MessageBox.Show("El código de la película ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Limpiar los campos
            tbCodigo.Text = "";
            tbNombre.Text = "";
            tbPais.Text = "";
            cbGenero.Text = "";
            nudDuracionEnMinutos.Text = "40";
            // Mostrar en el listView
            Mostrar(peliculaService.ListarTodo());
        }
    }
}
