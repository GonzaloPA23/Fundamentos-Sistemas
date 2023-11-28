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
using Negocio;
using Datos;
namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para UniversidadWindow.xaml
    /// </summary>
    public partial class UniversidadWindow : Window
    {
        private NUniversidad nUniversidad = new NUniversidad();
        Universidad universidadSeleccionada = null;

        public UniversidadWindow()
        {
            InitializeComponent();
            MostrarUniversidades(nUniversidad.ListarTodo());
        }
        private void MostrarUniversidades(List<Universidad> universidades)
        {
            dgvUniversidades.ItemsSource = new List<Universidad>();
            dgvUniversidades.ItemsSource = universidades;
        }
        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {

            if (txbNombre.Text == "" || txbRuc.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Universidad universidad = new Universidad
            {
                Nombre = txbNombre.Text,
                Ruc = txbRuc.Text
            };


            String mensaje = nUniversidad.Registrar(universidad);
            MessageBox.Show(mensaje);

            MostrarUniversidades(nUniversidad.ListarTodo());
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (txbNombre.Text == "" || txbRuc.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }


            if (universidadSeleccionada == null)
            {
                MessageBox.Show("Seleccione una universidad");
                return;
            }


            Universidad universidad = new Universidad
            {
                Id_universidad = universidadSeleccionada.Id_universidad,
                Nombre = txbNombre.Text,
                Ruc = txbRuc.Text
            };


            String mensaje = nUniversidad.Modificar(universidad);
            MessageBox.Show(mensaje);


            MostrarUniversidades(nUniversidad.ListarTodo());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (universidadSeleccionada == null)
            {
                MessageBox.Show("Seleccione una universidad");
                return;
            }


            String mensaje = nUniversidad.Eliminar(universidadSeleccionada.Id_universidad);
            MessageBox.Show(mensaje);

            MostrarUniversidades(nUniversidad.ListarTodo());
        }

        private void dgvUniversidades_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            universidadSeleccionada = dgvUniversidades.SelectedItem as Universidad;
            if (universidadSeleccionada != null)
            {
                txbNombre.Text = universidadSeleccionada.Nombre;
                txbRuc.Text = universidadSeleccionada.Ruc;
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
