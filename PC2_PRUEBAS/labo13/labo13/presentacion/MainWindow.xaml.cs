using entidades;
using negocio;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace presentacion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private nEmpleos negocioEmpleos = new nEmpleos();

        public MainWindow()
        {
            InitializeComponent();
            ActualizarDataGridEmpleos();
        }

        // Método para actualizar el DataGrid de empleos
        private void ActualizarDataGridEmpleos()
        {
            List<Empleos> empleos = negocioEmpleos.ObtenerTodosLosEmpleos();
            datagridEmpleos.ItemsSource = empleos;
        }

        // Método para limpiar los campos de empleo
        private void LimpiarCamposEmpleo()
        {
            txtNombreEmpleo.Text = string.Empty;
            txtSalarioMinimo.Text = string.Empty;
            txtSalarioMaximo.Text = string.Empty;
        }

        // Método para agregar un empleo
        private void BtnAgregarEmpleo_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombreEmpleo.Text;
            string salarioMinimoStr = txtSalarioMinimo.Text;
            string salarioMaximoStr = txtSalarioMaximo.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(salarioMinimoStr) || string.IsNullOrWhiteSpace(salarioMaximoStr))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar un empleo.");
                return;
            }

            decimal salarioMinimo = Convert.ToDecimal(salarioMinimoStr);
            decimal salarioMaximo = Convert.ToDecimal(salarioMaximoStr);
            negocioEmpleos.AgregarEmpleo(nombre, salarioMinimo, salarioMaximo);

            ActualizarDataGridEmpleos();
            LimpiarCamposEmpleo();
        }

        // Método para eliminar un empleo
        private void BtnEliminarEmpleo_Click(object sender, RoutedEventArgs e)
        {
            if (datagridEmpleos.SelectedItem != null)
            {
                Empleos empleoSeleccionado = (Empleos)datagridEmpleos.SelectedItem;
                int codigo = empleoSeleccionado.Código;
                negocioEmpleos.EliminarEmpleo(codigo);
                ActualizarDataGridEmpleos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleo para eliminar.");
            }
        }

        // Método para modificar un empleo
        private void BtnModificarEmpleo_Click(object sender, RoutedEventArgs e)
        {
            if (datagridEmpleos.SelectedItem != null)
            {
                Empleos empleoSeleccionado = (Empleos)datagridEmpleos.SelectedItem;
                int codigo = empleoSeleccionado.Código;
                string nombre = txtNombreEmpleo.Text;
                string salarioMinimoStr = txtSalarioMinimo.Text;
                string salarioMaximoStr = txtSalarioMaximo.Text;

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(salarioMinimoStr) || string.IsNullOrWhiteSpace(salarioMaximoStr))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de modificar el empleo.");
                    return;
                }

                decimal salarioMinimo = Convert.ToDecimal(salarioMinimoStr);
                decimal salarioMaximo = Convert.ToDecimal(salarioMaximoStr);

                Empleos empleoModificado = new Empleos
                {
                    Código = codigo,
                    NombreDelEmpleo = nombre,
                    SalarioMínimo = salarioMinimo,
                    SalarioMáximo = salarioMaximo
                };

                negocioEmpleos.ModificarEmpleo(empleoModificado);
                ActualizarDataGridEmpleos();
                LimpiarCamposEmpleo();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleo para modificar.");
            }
        }

        // Método para consultar empleos
        private void BtnConsultarEmpleos_Click(object sender, RoutedEventArgs e)
        {
            string salarioMinimoStr = txtSalarioMinimoConsulta.Text;
            string salarioMaximoStr = txtSalarioMaximoConsulta.Text;
            string nombre = txtNombreEmpleoConsulta.Text;

            if (string.IsNullOrWhiteSpace(salarioMinimoStr) || string.IsNullOrWhiteSpace(salarioMaximoStr))
            {
                MessageBox.Show("Por favor, complete los campos de salario mínimo y salario máximo antes de consultar.");
                return;
            }

            decimal salarioMinimo = Convert.ToDecimal(salarioMinimoStr);
            decimal salarioMaximo = Convert.ToDecimal(salarioMaximoStr);

            List<Empleos> empleosFiltrados = negocioEmpleos.ConsultarEmpleos(salarioMinimo, salarioMaximo, nombre);
            datagridEmpleos.ItemsSource = empleosFiltrados;
        }
    }
}
