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
    public partial class FormPersonaje : Form
    {
        private PersonajeService personajeService;
        public FormPersonaje(String codigoPelicula)
        {
            InitializeComponent();
            personajeService = new PersonajeService(codigoPelicula);
            Mostrar(personajeService.ListarTodo());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
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
            lblTotalPersonajes.Text = lista.Count.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbNombreActor.Text == "" || tbNombrePersonaje.Text == "" || cbSexo.Text == "" || nudMinutosAparicion.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validación de datos correctos para los campos
            if (!(cbSexo.Text.Contains("masculino") || cbSexo.Text.Contains("Masculino") || cbSexo.Text.Contains("femenino") || cbSexo.Text.Contains("Femenino") ||
                cbSexo.Text.Contains("no definido") || cbSexo.Text.Contains("No definido")))
            {
                MessageBox.Show("Debe ingresar un género correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Crear el objeto
            Personaje personaje = new()
            {
                Codigo = tbCodigo.Text,
                NombrePersonaje = tbNombrePersonaje.Text,
                NombreActor = tbNombreActor.Text,
                Genero = cbSexo.Text,
                MinutosAparicion = Convert.ToInt32(nudMinutosAparicion.Value)
            };
            // Instertar el objeto
            bool insertado = personajeService.InsertarPersonaje(personaje);
            if (!insertado)
            {
                MessageBox.Show("Ya existe un personaje con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Mostrar(personajeService.ListarTodo());
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            FormReportePersonaje formReportePersonaje = new FormReportePersonaje();
            formReportePersonaje.ShowDialog();
        }
    }
}
