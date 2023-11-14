using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Presentacion
{
    public partial class PeliculaWindow : Window
    {
        private NPelicula nPelicula = new NPelicula();
        private Pelicula peliculaSeleccionada = null;
        private bool filtroBuscar = false;
        public PeliculaWindow()
        {
            InitializeComponent();
            MostrarPeliculas(nPelicula.ListarTodo());
        }

        private void MostrarPeliculas(List<Pelicula> lst)
        {
            dgPelicula.ItemsSource = new List<Pelicula>();
            dgPelicula.ItemsSource = lst;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (txtDirector.Text == "" || txtTitulo.Text == "" || cbGenero.Text == "" || cbPais.Text == ""
                || dateFechaEstreno.SelectedDate == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            Pelicula pelicula = new Pelicula
            {
                Titulo = txtTitulo.Text,
                Director = txtDirector.Text,
                FechaEstreno = dateFechaEstreno.SelectedDate.Value,
                Genero = cbGenero.Text,
                Pais = cbPais.Text
            };

            String mensaje = nPelicula.Registrar(pelicula);
            MessageBox.Show(mensaje);

            txtDirector.Text = "";
            txtTitulo.Text = "";
            cbPais.SelectedIndex = -1;
            cbGenero.SelectedIndex = -1;
            dateFechaEstreno.SelectedDate = null;
            lbModificarCampos.Visibility = Visibility.Hidden;

            MostrarPeliculas(nPelicula.ListarTodo());
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            if (peliculaSeleccionada == null)
            {
                MessageBox.Show("Seleccione la pelicula a actualizar");
                return;
            }

            if (txtDirector.Text == "" || txtTitulo.Text == "" || cbGenero.Text == "" || cbPais.Text == ""
                || dateFechaEstreno.SelectedDate == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            Pelicula pelicula = new Pelicula
            {
                Id = peliculaSeleccionada.Id,
                Titulo = txtTitulo.Text,
                Director = txtDirector.Text,
                FechaEstreno = dateFechaEstreno.SelectedDate.Value,
                Genero = cbGenero.Text,
                Pais = cbPais.Text
            };

            String mensaje = nPelicula.Modificar(pelicula);
            MessageBox.Show(mensaje);

            txtDirector.Text = "";
            txtTitulo.Text = "";
            cbPais.SelectedIndex = -1;
            cbGenero.SelectedIndex = -1;
            dateFechaEstreno.SelectedDate = null;
            lbModificarCampos.Visibility = Visibility.Hidden;

            MostrarPeliculas(nPelicula.ListarTodo());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (peliculaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una pelicula");
                return;
            }

            String mensaje = nPelicula.Eliminar(peliculaSeleccionada.Id);
            MessageBox.Show(mensaje);

            txtDirector.Text = "";
            txtTitulo.Text = "";
            cbPais.SelectedIndex = -1;
            cbGenero.SelectedIndex = -1;
            dateFechaEstreno.SelectedDate = null;
            lbModificarCampos.Visibility = Visibility.Hidden;

            MostrarPeliculas(nPelicula.ListarTodo());
        }

        private void btnBuscarPorGenero_Click(object sender, RoutedEventArgs e)
        {
            if (cbBuscarPorGenero.Text == "")
            {
                MessageBox.Show("Por favor, seleccione un género");
                return;
            }

            MostrarPeliculas(nPelicula.BuscarPorGenero(cbBuscarPorGenero.Text));

            filtroBuscar = true;
            if (cbOrdenarPorFechaEstreno.Text != "") cbOrdenarPorFechaEstreno.SelectedIndex = -1;
        }

        private void btnOrdenarPorFechaEstreno_Click(object sender, RoutedEventArgs e)
        {
            if (cbOrdenarPorFechaEstreno.Text == "")
            {
                MessageBox.Show("Por favor, seleccione una opción");
                return;
            }

            if (filtroBuscar) MostrarPeliculas(nPelicula.OrdenarPorFechaEstreno(dgPelicula.ItemsSource as List<Pelicula>, cbOrdenarPorFechaEstreno.SelectedIndex));
            else MostrarPeliculas(nPelicula.OrdenarPorFechaEstreno(nPelicula.ListarTodo(), cbOrdenarPorFechaEstreno.SelectedIndex));
        }

        private void dgPelicula_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            peliculaSeleccionada = dgPelicula.SelectedItem as Pelicula;
            if (peliculaSeleccionada != null)
            {
                txtTitulo.Text = peliculaSeleccionada.Titulo;
                txtDirector.Text = peliculaSeleccionada.Director;
                cbGenero.Text = peliculaSeleccionada.Genero;
                dateFechaEstreno.SelectedDate = peliculaSeleccionada.FechaEstreno;
                cbPais.Text = peliculaSeleccionada.Pais;
                lbModificarCampos.Visibility = Visibility.Visible;
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            MostrarPeliculas(nPelicula.ListarTodo());
            cbBuscarPorGenero.SelectedIndex = -1;
            cbOrdenarPorFechaEstreno.SelectedIndex = -1;
            filtroBuscar = false;
        }

        private void dgPelicula_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyType == typeof(System.DateTime))
            {
                (e.Column as DataGridTextColumn).Binding.StringFormat = "dd/MM/yyyy";
            }
        }
    }
}
