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
    public partial class FormPokemon : Form
    {
        private PokemonService pokemonService;
        public FormPokemon(String codigoEntrenador)
        {
            InitializeComponent();
            pokemonService = new(codigoEntrenador);
            Mostrar(pokemonService.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPokemon_Load(object sender, EventArgs e)
        {

        }

        private void Mostrar(List<Pokemon> lista)
        {
            listViewPokemones.Items.Clear();
            int totalPuntoSalud = 0;
            foreach (Pokemon pokemon in lista)
            {
                ListViewItem item = new(pokemon.Codigo);
                item.SubItems.Add(pokemon.Nombre);
                item.SubItems.Add(pokemon.Apodo);
                item.SubItems.Add(pokemon.Tipo);
                item.SubItems.Add(pokemon.PuntosSalud.ToString());
                item.SubItems.Add(pokemon.Legendario.ToString()); //item.SubItems.Add(pokemon.Legendario ? "Sí" : "No");
                listViewPokemones.Items.Add(item);
                totalPuntoSalud += pokemon.PuntosSalud;
            }
            lbTotalPokemons.Text = lista.Count.ToString();
            lbTotalPSPokemons.Text = totalPuntoSalud.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbApodo.Text == "" || tbPuertoSalud.Text == "" || cbTipo.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de máximo de 6 pokemones
            if (pokemonService.ListarTodo().Count == 6)
            {
                MessageBox.Show("No puede registrar más de 6 pokemones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear el objeto
            Pokemon pokemon = new()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Apodo = tbApodo.Text,
                Tipo = cbTipo.Text,
                PuntosSalud = int.Parse(tbPuertoSalud.Text),
                Legendario = checkBoxEsLegendario.Checked
            };

            // Insertar
            bool insertado = pokemonService.Insertar(pokemon);
            if (!insertado)
            {
                MessageBox.Show("Ya existe un pokemon con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Actualizar ListView
            Mostrar(pokemonService.ListarTodo());
        }
    }
}
