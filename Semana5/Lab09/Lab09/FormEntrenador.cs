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
    public partial class FormEntrenador : Form
    {
        private EntrenadorService eS = new();
        public FormEntrenador()
        {
            InitializeComponent();
            Mostrar(eS.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte form = new FormReporte();
            form.Show();
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

        private void btnVerPokemons_Click(object sender, EventArgs e)
        {
            // Validación de selección
            if (listViewEntrenador.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un entrenador");
                return;
            }
            FormPokemon form = new(listViewEntrenador.SelectedItems[0].Text);
            form.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validacion de campos
            if (tbCodigo.Text == "" || tbEdad.Text == "" || tbNombre.Text == "" || cbRegion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            // Crear el objeto
            Entrenador entrenador = new()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Edad = int.Parse(tbEdad.Text),
                Region = cbRegion.Text,
                Pokemones = new List<Pokemon>()
            };
            // Insertar el objeto en la lista
            bool insertado = eS.Insertar(entrenador);
            if (!insertado)
            {
                MessageBox.Show("El codigo ya existe");
                return;
            }
            // Mostrar en el ListView
            Mostrar(eS.ListarTodo());
        }

        private void FormEntrenador_Load(object sender, EventArgs e)
        {

        }
    }
}
